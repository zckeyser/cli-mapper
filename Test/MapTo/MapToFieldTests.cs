using CLIMapper;
using NUnit.Framework;

namespace Test.MapTo
{
    [TestFixture]
    public class MapToFieldTests
    {
        [Test]
        public void Mapper_MapTo_StringField()
        {
            var args = new[] { "-StringField", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringField);
        }

        [Test]
        public void Mapper_MapTo_IntegerField()
        {
            var args = new[] { "-IntField", "1" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(1, mapped.IntField);
        }

        [Test]
        public void Mapper_MapTo_LongField()
        {
            var args = new[] { "-LongField", "123456789" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(123456789, mapped.LongField);
        }

        [Test]
        public void Mapper_MapTo_DoubleField()
        {
            var args = new[] { "-DoubleField", "3.14" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(3.14, mapped.DoubleField);
        }

        [Test]
        public void Mapper_MapTo_BooleanField_KeyValueStyle()
        {
            var args = new[] { "-BooleanField", "true" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.BooleanField);
        }

        [Test]
        public void Mapper_MapTo_BooleanField_FlagStyle()
        {
            var args = new[] { "-FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
        }

        [Test]
        public void Mapper_MapTo_BooleanField_FlagStyle_WithFollowingArgs()
        {
            var args = new[] { "-FlagField", "-StringField", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
            Assert.AreEqual("foo", mapped.StringField);
        }

        [Test]
        public void Mapper_MapTo_BooleanField_FlagStyle_WithPrecedingArgs()
        {
            var args = new[] { "-StringField", "foo", "-FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
            Assert.AreEqual("foo", mapped.StringField);
        }

        [Test]
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
