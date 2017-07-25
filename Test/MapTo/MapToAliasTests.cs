using System.Collections.Generic;
using CLIMapper;
using NUnit.Framework;

namespace Test.MapTo
{
    [TestFixture]
    public class MapToAliasTests
    {
        private static readonly long LongValue = ((long)int.MaxValue + 1);

        [Test]
        public void Mapper_MapTo_Alias_StringField()
        {
            var args = new[] { "-s", "foo" };

            var aliases = new Dictionary<string, string>
            {
                { "s", "StringField" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.AreEqual("foo", mapped.StringField);
        }

        [Test]
        public void Mapper_MapTo_Alias_IntField()
        {
            var args = new[] { "-i", "1" };

            var aliases = new Dictionary<string, string>
            {
                { "i", "IntField" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.AreEqual(1, mapped.IntField);
        }

        [Test]
        public void Mapper_MapTo_Alias_LongField()
        {
            var args = new[] { "-l", LongValue.ToString() };

            var aliases = new Dictionary<string, string>
            {
                { "l", "LongField" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.AreEqual(LongValue, mapped.LongField);
        }

        [Test]
        public void Mapper_MapTo_Alias_DoubleField()
        {
            var args = new[] { "-d", "1.1" };

            var aliases = new Dictionary<string, string>
            {
                { "d", "DoubleField" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.AreEqual(1.1, mapped.DoubleField);
        }

        [Test]
        public void Mapper_MapTo_Alias_BooleanField()
        {
            var args = new[] { "-b", "true" };

            var aliases = new Dictionary<string, string>
            {
                { "b", "BooleanField" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.IsTrue(mapped.BooleanField);
        }

        [Test]
        public void Mapper_MapTo_Alias_FlagField()
        {
            var args = new[] { "-f" };

            var aliases = new Dictionary<string, string>
            {
                { "f", "FlagField" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.IsTrue(mapped.FlagField);
        }

        [Test]
        public void Mapper_MapTo_Alias_StringProperty()
        {
            var args = new[] { "-s", "foo" };

            var aliases = new Dictionary<string, string>
            {
                { "s", "StringProperty" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.AreEqual("foo", mapped.StringProperty);
        }

        [Test]
        public void Mapper_MapTo_Alias_IntProperty()
        {
            var args = new[] { "-i", "1" };

            var aliases = new Dictionary<string, string>
            {
                { "i", "IntProperty" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.AreEqual(1, mapped.IntProperty);
        }

        [Test]
        public void Mapper_MapTo_Alias_LongProperty()
        {
            var args = new[] { "-l", LongValue.ToString() };

            var aliases = new Dictionary<string, string>
            {
                { "l", "LongProperty" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.AreEqual(LongValue, mapped.LongProperty);
        }

        [Test]
        public void Mapper_MapTo_Alias_DoubleProperty()
        {
            var args = new[] { "-d", "1.1" };

            var aliases = new Dictionary<string, string>
            {
                { "d", "DoubleProperty" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.AreEqual(1.1, mapped.DoubleProperty);
        }

        [Test]
        public void Mapper_MapTo_Alias_BooleanProperty()
        {
            var args = new[] { "-b", "true" };

            var aliases = new Dictionary<string, string>
            {
                { "b", "BooleanProperty" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.IsTrue(mapped.BooleanProperty);
        }

        [Test]
        public void Mapper_MapTo_Alias_FlagProperty()
        {
            var args = new[] { "-f" };

            var aliases = new Dictionary<string, string>
            {
                { "f", "FlagProperty" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.IsTrue(mapped.FlagProperty);
        }
    }
}
