# C# CLI Mapper
This project is a utility which takes the arguments to a program as a parameter, and returns a map of all of the arguments parsed out into key-value pairs based on flag-value pairs in the argument list. Types are also coerced out of the given arguments, and any flag prefix you want (including none) can be used. See the examples below to see how it works in practice.

```csharp
string[] args = {"--string", "foo", "--bool", "true", "--int", "1", "--double", "1.1", "--long", "2147483648"};

Dictionary<string, object> map = Mapper.Map(args);

map["string"] == "foo";
map["bool"] == true;
map["int"] == 1;
map["double"] == 1.1;
map["long"] == 2147483648L;
```
