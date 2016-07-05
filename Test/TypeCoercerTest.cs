using Microsoft.VisualStudio.TestTools.UnitTesting;
using Options;

namespace Test
{
    [TestClass]
    public class TypeCoercerTest
    {
        private TypeCoercer coercer;

        [TestInitialize]
        public void Initialize()
        {
            coercer = new TypeCoercer();
        }

        [TestMethod]
        public void TypeCoercer_Coerce_CoercesBool()
        {
            string toCoerce = "true";

            var result = coercer.Coerce(toCoerce);

            Assert.IsInstanceOfType(result, typeof(bool));
        }

        [TestMethod]
        public void TypeCoercer_Coerce_CoercesDouble()
        {
            string toCoerce = "1.1";

            var result = coercer.Coerce(toCoerce);

            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        public void TypeCoercer_Coerce_CoercesInt()
        {
            string toCoerce = "1";

            var result = coercer.Coerce(toCoerce);

            Assert.IsInstanceOfType(result, typeof(int));
        }

        [TestMethod]
        public void TypeCoercer_Coerce_CoercesLong()
        {
            string toCoerce = ((long) int.MaxValue + 1).ToString();

            var result = coercer.Coerce(toCoerce);

            Assert.IsInstanceOfType(result, typeof(long));
        }

        [TestMethod]
        public void TypeCoercer_Coerce_CoercesString()
        {
            string toCoerce = "foo";

            var result = coercer.Coerce(toCoerce);

            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
