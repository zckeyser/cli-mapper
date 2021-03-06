﻿using System.Collections.Generic;
using CLIMapper;
using NUnit.Framework;

namespace Test.MapTo
{
    [TestFixture]
    public class MapToInvalidInputTests
    {
        [Test]
        public void Mapper_MapTo_InvalidAlias()
        {
            var args = new[] { "-s", "foo" };

            var badAliases = new Dictionary<string, string>
            {
                {"s", "FUBAR"}
            };

            var mapped = Mapper.MapTo<TestOptions>(args, badAliases);

            Assert.AreEqual(null, mapped.StringField);
        }

        [Test]
        public void Mapper_MapTo_OutOfRangeInteger()
        {
            var args = new[] { "-IntField", };

            var mapped = Mapper.MapTo<TestOptions>(args);

            // should have not been set, and as such will be the default
            Assert.AreEqual(mapped.IntField, default(int));
        }

        [Test]
        public void Mapper_MapTo_IgnoresBadKeys()
        {
            var args = new[] { "-Foo", "bar" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsNotNull(mapped);
        }

        [Test]
        public void Mapper_MapTo_IgnoresBadValues()
        {
            var args = new[] { "-BooleanField", "1234" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsNotNull(mapped);
            Assert.IsFalse(mapped.BooleanField);
        }

        [Test]
        public void Mapper_MapTo_IgnoresBadFlags()
        {
            var args = new[] { "-FooBar" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsNotNull(mapped);
        }

        [Test]
        public void Mapper_MapTo_IgnoresUnPrefixedFlags()
        {
            var args = new[] { "BooleanField", "true", "FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsFalse(mapped.BooleanField);
            Assert.IsFalse(mapped.FlagField);
        }
    }
}
