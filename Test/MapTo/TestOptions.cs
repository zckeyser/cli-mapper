using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.MapTo
{
    public class TestOptions
    {
        public int IntField;

        public long LongField;

        public double DoubleField;

        public string StringField;

        public bool BooleanField;

        public bool FlagField;

        public int IntProperty { get; set; }
        public long LongProperty { get; set; }
        public double DoubleProperty { get; set; }
        public string StringProperty { get; set; }
        public bool BooleanProperty { get; set; }
        public bool FlagProperty { get; set; }
    }
}
