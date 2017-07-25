using CLIMapper;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class TypeCoercerTest
    {
        private TypeCoercer coercer;

        [SetUp]
        public void Initialize()
        {
            coercer = new TypeCoercer();
        }

        [Test]
        public void TypeCoercer_Coerce_CoercesBool()
        {
            string toCoerce = "true";

            var result = coercer.Coerce(toCoerce);

            Assert.AreEqual(result, true);
        }

        [Test]
        public void TypeCoercer_Coerce_CoercesDouble()
        {
            string toCoerce = "1.1";

            var result = coercer.Coerce(toCoerce);

            Assert.AreEqual(result, 1.1);
        }

        [Test]
        public void TypeCoercer_Coerce_CoercesInt()
        {
            string toCoerce = "1";

            var result = coercer.Coerce(toCoerce);

            Assert.AreEqual(result, 1);
        }

        [Test]
        public void TypeCoercer_Coerce_CoercesLong()
        {
            string toCoerce = ((long)int.MaxValue + 1).ToString();

            var result = coercer.Coerce(toCoerce);

            Assert.AreEqual(result, (long)int.MaxValue + 1);
        }

        [Test]
        public void TypeCoercer_Coerce_CoercesString()
        {
            string toCoerce = "foo";

            var result = coercer.Coerce(toCoerce);

            Assert.AreEqual(result, "foo");
        }
    }
}
