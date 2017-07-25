# C# CLI Mapper

This project is a utility which takes the arguments to a program as a parameter, and returns a map of all of the arguments parsed out into key-value pairs based on flag-value pairs in the argument list. Types are also coerced out of the given arguments, and any flag prefix you want (including none) can be used. Arguments can also be parsed into a given type, mapping either by checking if a flag is a field on the given type, or by using a given alias to map flags to fields on the type. See the examples below to see how it works in practice.

## Installation

This project is on NuGet as [CLI-Argument-Mapper](https://www.nuget.org/packages/CLI-Argument-Mapper). It can be installed via Visual Studio or by running the following in PowerShell:

```powershell
Install-Package CLI-Argument-Mapper
```

## Usage

Any combination of prefix, alias and defaults (which are shown individually below) can be used when calling `MapTo`. In addition, arguments which both do not follow a flag and are not prefixed with `flagPrefix` (default `--`) will be ignored.

- [Map to a Dictionary](#map-to-a-dictionary)
- [Map to an Object](#map-to-an-object)
- [Changing the Flag Prefix](#changing-the-flag-prefix)
- [Map to an Object with Aliases](#map-to-an-object-with-aliases)
- [Using Default Values](#using-default-values)
- [Defaults with an Anonymous Object](#defaults-with-an-anonymous-object)

### Map to a Dictionary

```cs
// mapping to a dictionary
string[] args = {"--string", "foo", "--bool", "true", "--int", "1", "--double", "1.1", "--long", "2147483648"};

Dictionary<string, object> map = Mapper.Map(args);

map["string"] == "foo";
map["bool"] == true;
map["int"] == 1;
map["double"] == 1.1;
map["long"] == 2147483648L;
```

### Map to an Object

```cs
// mapping to an object
args = {"--String", "foo", "--Boolean", "true", "--Integer", "1", "--Double", "1.1", "--Long", "2147483648", "--Flag"};

class TestOptions
{
    public string String;
    public bool Boolean;
    public int Integer;
    public double Double;
    public long Long;
    public bool Flag;
}

var options = Mapper.MapTo<TestOptions>(args);

options.String == "foo";
options.Boolean == true;
options.Integer == 1;
options.Double == 1.1;
options.Long == 2147483648L;
options.Flag == true;
```

### Execute Commands

CLI Mapper can execute actions dynamically based on command line input using `Command.Execute` for up to 16 commands.

`Command.Execute` will choose what action to call based on what command string is given as an argument,
and it will attempt to parse any subsequent input into the type corresponding to that command's action.
Aliases and flag prefix overrides (default `--`) can be provided as optional arguments. Due to restrictions
of C# optional arguments, if only aliases and not a prefix is to be passed, you will need to specify the
variable as follows: `Command.Execute(args, fooAction, barAction, aliases: aliases)`

Command names can either be directly specified by implementing the `ICommand` interface, or left to default to the class name.

Command names are case-insensitive.

```cs
class Foo
{
    public string s;
}

class Bar : ICommand
{
    public string Command => "fizz";

    public int i;
}

Action<Foo> fooAction = f => Console.WriteLine(s);
Action<Bar> barAction = f => Console.WriteLine(i);

string[] fooArgs = new[] { "foo", "--s", "buzz" }

// prints "buzz"
Command.Execute(fooArgs, fooAction, barAction);

string[] barArgs = new[] { "fizz", "--i", "10" }

// prints "10"
Command.Execute(barArgs, fooAction, barAction);
```
