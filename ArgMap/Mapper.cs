using System.Collections.Generic;
using System.Text;

namespace ArgMap
{
    public static class Mapper
    {
        public static Dictionary<string, object> Map(IList<string> args, string flagPrefix = "--")
        {
            var map = new Dictionary<string, object>();
            var sb = new StringBuilder();
            var coercer = new TypeCoercer();

            if (args.Count % 2 != 0)
                sb.AppendLine("warning: uneven argument count");

            // check up to second-to-last argument
            for(var i = 0; i < args.Count - 1; i++)
            {
                var flag = args[i];
                var value = args[i + 1];
                
                if(flag.StartsWith(flagPrefix))
                {
                    // remove the prefix when making the key
                    var key = flag.Substring(flagPrefix.Length);
                    map[key] = coercer.Coerce(value);
                }
            }

            return map;
        }
    }
}
