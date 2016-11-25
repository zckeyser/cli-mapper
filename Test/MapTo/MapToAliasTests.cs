using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.MapTo
{
    [TestClass]
    public class MapToAliasTests
    {
        private static readonly long LongValue = ((long)int.MaxValue + 1);

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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
