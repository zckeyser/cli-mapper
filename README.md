# C# CLI Mapper
This project is a utility which takes the arguments to a program as a parameter, and returns a map of all of the arguments parsed out into key-value pairs based on flag-value pairs in the argument list. Types are also coerced out of the given arguments, and any flag prefix you want (including none) can be used. See the examples below to see how it works in practice.

```csharp
// mapping to a dictionary
string[] args = {"--string", "foo", "--bool", "true", "--int", "1", "--double", "1.1", "--long", "2147483648"};

Dictionary<string, object> map = Mapper.Map(args);

map["string"] == "foo";
map["bool"] == true;
map["int"] == 1;
map["double"] == 1.1;
map["long"] == 2147483648L;

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

var options = Mapper.MapTo(args, typeof(TestOptions)) as TestOptions;

options.String == "foo";
options.Boolean == true;
options.Integer == 1;
options.Double == 1.1;
options.Long == 2147483648L;
options.Flag == true;
```
