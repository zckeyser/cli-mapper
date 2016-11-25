using CLIMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.MapTo
{
    [TestClass]
    public class MapToFieldTests
    {
        [TestMethod]
        public void Mapper_MapTo_StringField()
        {
            var args = new[] { "-StringField", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringField);
        }

        [TestMethod]
        public void Mapper_MapTo_IntegerField()
        {
            var args = new[] { "-IntField", "1" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(1, mapped.IntField);
        }

        [TestMethod]
        public void Mapper_MapTo_LongField()
        {
            var args = new[] { "-LongField", "123456789" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(123456789, mapped.LongField);
        }

        [TestMethod]
        public void Mapper_MapTo_DoubleField()
        {
            var args = new[] { "-DoubleField", "3.14" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(3.14, mapped.DoubleField);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_KeyValueStyle()
        {
            var args = new[] { "-BooleanField", "true" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.BooleanField);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_FlagStyle()
        {
            var args = new[] { "-FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_FlagStyle_WithFollowingArgs()
        {
            var args = new[] { "-FlagField", "-StringField", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
            Assert.AreEqual("foo", mapped.StringField);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_FlagStyle_WithPrecedingArgs()
        {
            var args = new[] { "-StringField", "foo", "-FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
            Assert.AreEqual("foo", mapped.StringField);
        }

        [TestMethod]
        public void Mapper_MapTo_AllFieldValues()
        {
            var args = new[] { "-StringField", "foo", "-IntField", "1", "-LongField", "123456789", "-DoubleField", "3.14", "-BooleanField", "true", "-FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringField);
            Assert.AreEqual(1, mapped.IntField);
            Assert.AreEqual(123456789, mapped.LongField);
            Assert.AreEqual(3.14, mapped.DoubleField);
            Assert.IsTrue(mapped.BooleanField);
            Assert.IsTrue(mapped.FlagField);
        }
    }
}
