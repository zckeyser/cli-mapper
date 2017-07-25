# C# CLI Mapper
This project is a utility which takes the arguments to a program as a parameter, and returns a map of all of the arguments parsed out into key-value pairs based on flag-value pairs in the argument list. Types are also coerced out of the given arguments, and any flag prefix you want (including none) can be used. Arguments can also be parsed into a given type, mapping either by checking if a flag is a field on the given type, or by using a given alias to map flags to fields on the type. See the examples below to see how it works in practice.

## Installation
This project is on NuGet as [CLI-Argument-Mapper](https://www.nuget.org/packages/CLI-Argument-Mapper). It can be installed via Visual Studio or by running the following in PowerShell:
```
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

private class TestOptions
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

### Changing the Flag Prefix
```cs
string[] args = {"/string", "foo", "/bool", "true", "/int", "1", "/double", "1.1", "/long", "2147483648"};

Dictionary<string, object> map = Mapper.Map(args, "/");

map["string"] == "foo";
map["bool"] == true;
map["int"] == 1;
map["double"] == 1.1;
map["long"] == 2147483648L;
```

### Map to an Object with Aliases
```cs
// mapping to an object using aliases
args = {"--s", "foo", "--b", "true", "--i", "1", "--d", "1.1", "--l", "2147483648", "--f"}
Dictionary<string, string> aliases = new Dictionary<string, string>()
    {
        { "s", "String" },
        { "b", "Boolean" },
        { "i", "Integer" },
        { "d", "Double" },
        { "l", "Long" }
        { "f", "Flag" }
    };

options = Mapper.MapTo<TestOptions>(args, aliases);

options.String == "foo";
options.Boolean == true;
options.Integer == 1;
options.Double == 1.1;
options.Long == 2147483648L;
options.Flag == true;
```

### Using Default Values

```cs
// setting defaults when mapping
var defaultValues = new TestOptions
{
    String = "foo",
    Boolean = true,
    Integer = 1,
    Double = 1.1,
    Long = 2147483648L,
    Flag = true
};

// you can leave out the generic specification if you're passing an object of the type
options = Mapper.MapTo(new string[0], defaultValues);

options.String == "foo";
options.Boolean == true;
options.Integer == 1;
options.Double == 1.1;
options.Long == 2147483648L;
options.Flag = true;
```

### Defaults with an Anonymous Object

```cs
// you can use an anonymous object too
var anonymousDefaults = new
{
    String = "foo",
    Boolean = true,
    Integer = 1,
    Double = 1.1,
    Long = 2147483648L,
    Flag = true
};

options = Mapper.MapTo<TestOptions>(new string[0], anonymousDefaults);

options.String == "foo";
options.Boolean == true;
options.Integer == 1;
options.Double == 1.1;
options.Long == 2147483648L;
options.Flag = true;
```
