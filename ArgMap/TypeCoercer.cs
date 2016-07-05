namespace ArgMap
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
            return d % 1 == 0;
        }
    }
}
