using NUnit.Framework;

namespace Test.MapTo
{
    [TestFixture]
    public class MapToDefaultTests
    {
        [Test]
        public void MapTo_Default_ObjectOfType_DefaultsFieldCorrectly()
        {
            var defaultValues = new TestOptions
            {
                IntField = 1,
                LongField = 1,
                DoubleField = 1.0,
                StringField = "foo",
                BooleanField = true,
                FlagField = true
            };

            var result = CLIMapper.Mapper.MapTo(new string[0], defaultValues);

            Assert.AreEqual(1, result.IntField);
            Assert.AreEqual(1L, result.LongField);
            Assert.AreEqual(1.0, result.DoubleField);
            Assert.AreEqual("foo", result.StringField);
            Assert.IsTrue(result.BooleanField);
            Assert.IsTrue(result.FlagField);
        }

        [Test]
        public void MapTo_Default_ObjectOfType_DefaultsPropertyCorrectly()
        {
            var defaultValues = new TestOptions
            {
                IntProperty = 1,
                LongProperty = 1,
                DoubleProperty = 1.0,
                StringProperty = "foo",
                BooleanProperty = true,
                FlagProperty = true
            };

            var result = CLIMapper.Mapper.MapTo(new string[0], defaultValues);

            Assert.AreEqual(1, result.IntProperty);
            Assert.AreEqual(1L, result.LongProperty);
            Assert.AreEqual(1.0, result.DoubleProperty);
            Assert.AreEqual("foo", result.StringProperty);
            Assert.IsTrue(result.BooleanProperty);
            Assert.IsTrue(result.FlagProperty);
        }

        [Test]
        public void MapTo_Default_AnonymousObject_DefaultsFieldCorrectly()
        {
            var defaultValues = new
            {
                IntField = 1,
                LongField = 1,
                DoubleField = 1.0,
                StringField = "foo",
                BooleanField = true,
                FlagField = true
            };

            var result = CLIMapper.Mapper.MapTo(new string[0], defaultValues);

            Assert.AreEqual(1, result.IntField);
            Assert.AreEqual(1L, result.LongField);
            Assert.AreEqual(1.0, result.DoubleField);
            Assert.AreEqual("foo", result.StringField);
            Assert.IsTrue(result.BooleanField);
            Assert.IsTrue(result.FlagField);
        }

        [Test]
        public void MapTo_Default_AnonymousObject_DefaultsPropertyCorrectly()
        {
            var defaultValues = new
            {
                IntProperty = 1,
                LongProperty = 1,
                DoubleProperty = 1.0,
                StringProperty = "foo",
                BooleanProperty = true,
                FlagProperty = true
            };

            var result = CLIMapper.Mapper.MapTo(new string[0], defaultValues);

            Assert.AreEqual(1, result.IntProperty);
            Assert.AreEqual(1L, result.LongProperty);
            Assert.AreEqual(1.0, result.DoubleProperty);
            Assert.AreEqual("foo", result.StringProperty);
            Assert.IsTrue(result.BooleanProperty);
            Assert.IsTrue(result.FlagProperty);
        }

        [Test]
        public void MapTo_Default_AnonymousObject_IgnoresNonMatchingProperties()
        {
            var defaultValues = new
            {
                AFakeProperty = 1000,
                IntProperty = 1
            };

            var result = CLIMapper.Mapper.MapTo(new string[0], defaultValues);

            // make sure assignments still worked
            Assert.AreEqual(1, result.IntProperty);
        }
    }
}
