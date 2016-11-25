using CLIMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.MapTo
{
    [TestClass]
    public class MapToPropertyTests
    {
        [TestMethod]
        public void Mapper_MapTo_StringProperty()
        {
            var args = new[] { "-StringProperty", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_IntegerProperty()
        {
            var args = new[] { "-IntProperty", "1" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(1, mapped.IntProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_LongProperty()
        {
            var args = new[] { "-LongProperty", "123456789" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(123456789, mapped.LongProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_DoubleProperty()
        {
            var args = new[] { "-DoubleProperty", "3.14" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(3.14, mapped.DoubleProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanProperty_KeyValueStyle()
        {
            var args = new[] { "-BooleanProperty", "true" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.BooleanProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanProperty_FlagStyle()
        {
            var args = new[] { "-FlagProperty" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanProperty_FlagStyle_WithFollowingArgs()
        {
            var args = new[] { "-FlagProperty", "-StringProperty", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagProperty);
            Assert.AreEqual("foo", mapped.StringProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanProperty_FlagStyle_WithPrecedingArgs()
        {
            var args = new[] { "-StringProperty", "foo", "-FlagProperty" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagProperty);
            Assert.AreEqual("foo", mapped.StringProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_AllPropertyValues()
        {
            var args = new[] { "-StringProperty", "foo", "-IntProperty", "1", "-LongProperty", "123456789", "-DoubleProperty", "3.14", "-BooleanProperty", "true", "-FlagProperty" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringProperty);
            Assert.AreEqual(1, mapped.IntProperty);
            Assert.AreEqual(123456789, mapped.LongProperty);
            Assert.AreEqual(3.14, mapped.DoubleProperty);
            Assert.IsTrue(mapped.BooleanProperty);
            Assert.IsTrue(mapped.FlagProperty);
        }
    }
}
