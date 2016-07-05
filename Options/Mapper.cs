using System;
using System.Collections.Generic;

namespace Options
{
    public static class Mapper
    {
        public static Dictionary<string, object> Map(IList<string> args, string flagPrefix = "--")
        {
            var map = new Dictionary<string, object>();
            var coercer = new TypeCoercer();

            // check up to second-to-last argument
            for(var i = 0; i < args.Count; i += 2)
            {
                var flag = args[i];
                
                if(flag.StartsWith(flagPrefix))
                {
                    // remove the prefix when making the key
                    var key = flag.Substring(flagPrefix.Length);

                    if(i < args.Count - 1)
                    {
                        var value = args[i + 1];
                        map[key] = coercer.Coerce(value);
                    }
                    else
                    {
                        // if the flag is alone, we're going
                        // to treat it like an option flag
                        // instead of an argument marking flag
                        map[key] = true;
                    }
                }
            }

            return map;
        }

	    public static object MapTo(IList<string> args, Type t, Dictionary<string, string> aliases)
	    {
		    return MapTo(args, t, "--", aliases);
	    }

        public static object MapTo(IList<string> args, Type t, string flagPrefix = "--", Dictionary<string, string> aliases = null)
        {
            var coercer = new TypeCoercer();
            var obj = Activator.CreateInstance(t);
	        aliases = aliases ?? new Dictionary<string, string>();

            for(var i = 0; i < args.Count; i++)
            {
                var flag = args[i];

                if(flag.StartsWith(flagPrefix))
                {
                    // cut off the prefix to get the key
                    var key = flag.Substring(flagPrefix.Length);

					// check if the field is contained, or else if the 
					// field is contained w/a capital first letter
                    var field = t.GetField(key) ?? t.GetField(key.Substring(0, 1).ToUpper() + key.Substring(1));

					// if we have an alias, assign with it
	                if (field == null && aliases.ContainsKey(key))
		                field = t.GetField(aliases[key]);

	                // if the given type contains this field,
                    // we can start processing it
                    if(field != null)
                    {
                        var fieldType = field.FieldType;

                        // if this isn't the last argument
                        // and the next argument isn't a flag
                        // we know it's a key-value type arg
                        if (i < args.Count - 1 && !args[i + 1].StartsWith(flagPrefix))
                        {
                            bool success = true;
                            var value = args[i + 1];

                            // if we already want a string, no need to coerce
                            var coercedValue = fieldType == typeof(string) ? value : coercer.CoerceTo(value, fieldType, out success);

                            if(success)
                            {
                                field.SetValue(obj, coercedValue);
                            }
                        }
                        else if(fieldType == typeof(bool))
                        {
                            // this is only valid if we're assigning to a boolean field

                            // if there's no corresponding argument we can treat it
                            // like a boolean flag
                            field.SetValue(obj, true);
                        }
                    }
                }
            }

            return obj;
        }
    }
}
