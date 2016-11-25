using System;
using System.ComponentModel;

namespace CLIMapper
{
    public class TypeCoercer
    {
        public object Coerce(string s)
        {
            bool boolVal;
            double doubleVal;
            int intVal;
            long longVal;

            if (bool.TryParse(s, out boolVal))
                return boolVal;
            if (double.TryParse(s, out doubleVal) && !IsIntegerValue(doubleVal))
                return doubleVal;
            if (int.TryParse(s, out intVal))
                return intVal;
            if (long.TryParse(s, out longVal))
                return longVal;
        
            // we've determined that it isn't 
            // one of the other primitives    
            return s;
        }

        private static bool IsIntegerValue(double d)
        {
            return Math.Abs(d % 1) < .00000001;
        }

        public object CoerceTo(string s, Type t, out bool success)
        {
            var converter = TypeDescriptor.GetConverter(t);

            // see if we can convert this type from a string
            if(converter != null)
            {
                // if we can, give it a try
                try
                {
                    success = true;
                    var value = converter.ConvertFromString(s);
                    return value;
                }
                catch (Exception)
                {
                    // if the parse fails return null
                    success = false;
                    return null;
                }
            }
            else
            {
                // no converter available to parse the value
                success = false;
                return null;
            }
        }
    }
}
