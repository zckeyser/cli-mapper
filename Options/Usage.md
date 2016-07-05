# Usage
The following are examples of how the mapper can be used to pack arguments into both maps and objects:

## Packing into a Map
```csharp
string[] args = {"--string", "foo", "--bool", "true", "--int", "1", "--double", "1.1", "--long", "2147483648", "--flag"};

Dictionary<string, object> map = Mapper.Map(args);

map["string"] == "foo";
map["bool"] == true;
map["int"] == 1;
map["double"] == 1.1;
map["long"] == 2147483648L;
map["flag"] == true;
```

## Packing into an Object
```csharp
string[] args = {"--String", "foo", "--Boolean", "true", "--Integer", "1", "--Double", "1.1", "--Long", "2147483648", "--Flag"};

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

## Packing with an alternate prefix
```csharp
string[] args = {"/string", "foo", "/bool", "true", "/int", "1", "/double", "1.1", "/long", "2147483648", "/flag"};

Dictionary<string, object> map = Mapper.Map(args, "/");

map["string"] == "foo";
map["bool"] == true;
map["int"] == 1;
map["double"] == 1.1;
map["long"] == 2147483648L;
map["flag"] == true;
```
