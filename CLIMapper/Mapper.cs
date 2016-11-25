using System;
using System.Collections.Generic;
using System.Reflection;

namespace CLIMapper
{
    public static class Mapper
    {
        public static Dictionary<string, object> Map(IList<string> args, string flagPrefix = "--")
        {
            var map = new Dictionary<string, object>();
            var coercer = new TypeCoercer();

            // check up to second-to-last argument
            for(var i = 0; i < args.Count; i++)
            {
                var flag = args[i];
                
                if(flag.StartsWith(flagPrefix))
                {
                    // remove the prefix when making the key
                    var key = flag.Substring(flagPrefix.Length);

                    if(i < args.Count - 1 && !args[i + 1].StartsWith(flagPrefix))
                    {
                        var value = args[i + 1];
                        map[key] = coercer.Coerce(value);

                        // skip the corresponding value for the next loop, so we hit the next flag instead
                        i++;
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

        public static T MapTo<T>(IList<string> args)
            where T : class
        {
            return MapTo(args, "-", null, default(T));
        }

        public static T MapTo<T>(IList<string> args, string flagPrefix)
            where T : class
        {
            return MapTo(args, "-", null, default(T));
        }

        public static T MapTo<T>(IList<string> args, string flagPrefix, Dictionary<string, string> aliases)
            where T : class
        {
            return MapTo(args, flagPrefix, aliases, default(T));
        }

        public static T MapTo<T>(IList<string> args, Dictionary<string, string> aliases)
            where T : class
        {
            return MapTo(args, "-", aliases, default(T));
        }

        public static T MapTo<T>(IList<string> args, string flagPrefix, dynamic defaultValue)
        {
            return MapTo(args, flagPrefix, null, DynamicToType<T>(defaultValue));
        }

        public static T MapTo<T>(IList<string> args, Dictionary<string, string> aliases, dynamic defaultValue)
        {
            return MapTo(args, "-", aliases, DynamicToType<T>(defaultValue));
        }

        public static T MapTo<T>(IList<string> args, string flagPrefix, Dictionary<string, string> aliases, dynamic defaultValue)
        {
            return MapTo(args, flagPrefix, aliases, DynamicToType<T>(defaultValue));
        }

        private static T DynamicToType<T>(dynamic obj)
        {
            var t = typeof(T);
            var retv = (T) Activator.CreateInstance(t);

            // map all properties over
            foreach (var prop in retv.GetType().GetProperties(BindingFlags.Public | BindingFlags.Static))
            {
                if (obj.Contains(prop.Name))
                    prop.SetValue(retv, obj[prop.Name]);
            }

            // map all fields over
            foreach (var field in retv.GetType().GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                if(obj.Contains(field.Name))
                    field.SetValue(retv, obj[field.Name]);
            }

            return retv;
        }

        /// <summary>
        /// map arguments to a given type using flags on the arguments to map to fields/properties
        /// </summary>
        public static T MapTo<T>(IList<string> args, string flagPrefix, Dictionary<string, string> aliases, T defaultValue)
            where T : class
        {
            var t = typeof(T);

            var coercer = new TypeCoercer();
            var obj = defaultValue ?? (T) Activator.CreateInstance(t);
            aliases = aliases ?? new Dictionary<string, string>();

            for (var i = 0; i < args.Count; i++)
            {
                var flag = args[i];

                if (flag.StartsWith(flagPrefix))
                {
                    // cut off the prefix to get the key
                    var key = flag.Substring(flagPrefix.Length);

                    // check if the field is contained, or else if the 
                    // field is contained w/a capital first letter,
                    // and do the same thing for properties
                    var field = t.GetField(key) ?? t.GetField(key.Substring(0, 1).ToUpper() + key.Substring(1));
                    var property = t.GetProperty(key) ?? t.GetProperty(key.Substring(0, 1).ToUpper() + key.Substring(1));

                    // if we have an alias, assign with it
                    if (field == null && aliases.ContainsKey(key))
                        field = t.GetField(aliases[key]);

                    if (property == null && aliases.ContainsKey(key))
                        property = t.GetProperty(aliases[key]);

                    // if the given type contains this field,
                    // we can start processing it
                    if (field != null)
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

                            if (success)
                            {
                                field.SetValue(obj, coercedValue);
                            }
                        }
                        else if (fieldType == typeof(bool))
                        {
                            // this is only valid if we're assigning to a boolean field

                            // if there's no corresponding argument we can treat it
                            // like a boolean flag
                            field.SetValue(obj, true);
                        }
                    }
                    else if (property != null)
                    {
                        var propertyType = property.PropertyType;

                        // if this isn't the last argument
                        // and the next argument isn't a flag
                        // we know it's a key-value type arg
                        if (i < args.Count - 1 && !args[i + 1].StartsWith(flagPrefix))
                        {
                            bool success = true;
                            var value = args[i + 1];

                            // if we already want a string, no need to coerce
                            var coercedValue = propertyType == typeof(string) ? value : coercer.CoerceTo(value, propertyType, out success);

                            if (success)
                                property.SetValue(obj, coercedValue);
                        }
                        else if (propertyType == typeof(bool))
                        {
                            // this is only valid if we're assigning to a boolean field

                            // if there's no corresponding argument we can treat it
                            // like a boolean flag
                            property.SetValue(obj, true);
                        }
                    }
                }
            }

            return obj;
        }
    }
}
