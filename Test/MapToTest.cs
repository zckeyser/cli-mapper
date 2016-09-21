using Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class MapToTest
    {
        private static readonly Type mappingType = typeof(TestOptions);
        private string[] args;

        private class TestOptions
        {
            public int Integer;

            public long Long;

            public double Double;

            public string String;

            public bool Boolean;

            public bool Flag;
        }

        [TestInitialize]
        public void Initialize() { args = new string[0]; }

        [TestMethod]
        public void Mapper_MapTo_ReturnsObjectOfCorrectType()
        {
            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_StringField()
        {
			args = new[] { "--String", "foo" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual("foo", mapped.String);
        }

        [TestMethod]
        public void Mapper_MapTo_IntegerField()
        {
	        args = new[] { "--Integer", "1" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual(1, mapped.Integer);
        }

        [TestMethod]
        public void Mapper_MapTo_LongField()
        {
	        args = new[] { "--Long", "123456789" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual(123456789, mapped.Long);
        }

        [TestMethod]
        public void Mapper_MapTo_DoubleField()
        {
	        args = new[] { "--Double", "3.14" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual(3.14, mapped.Double);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_KeyValueStyle()
        {
			args = new[] { "--Boolean", "true" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsTrue(mapped.Boolean);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_FlagStyle()
        {
	        args = new[] { "--Flag" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsTrue(mapped.Flag);
        }

        [TestMethod]
        public void Mapper_MapTo_AllValues()
        {
	        args = new[] { "--String", "foo", "--Integer", "1", "--Long", "123456789", "--Double", "3.14", "--Boolean", "true", "--Flag" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual("foo", mapped.String);
            Assert.AreEqual(1, mapped.Integer);
            Assert.AreEqual(123456789, mapped.Long);
            Assert.AreEqual(3.14, mapped.Double);
            Assert.IsTrue(mapped.Boolean);
            Assert.IsTrue(mapped.Flag);
        }

	    [TestMethod]
	    public void Mapper_MapTo_UsesAliases()
	    {
			args = new[] { "--s", "foo", "--i", "1", "--l", "123456789", "--d", "3.14", "--b", "true", "--f" };

			var aliases = new Dictionary<string, string>
			{
				{"s", "String"},
				{"i", "Integer"},
				{"l", "Long"},
				{"d", "Double"},
				{"b", "Boolean"},
				{"f", "Flag"}
			};

			var mapped = Mapper.MapTo(args, mappingType, aliases: aliases) as TestOptions;

			Assert.AreEqual("foo", mapped.String);
			Assert.AreEqual(1, mapped.Integer);
			Assert.AreEqual(123456789, mapped.Long);
			Assert.AreEqual(3.14, mapped.Double);
			Assert.IsTrue(mapped.Boolean);
			Assert.IsTrue(mapped.Flag);
	    }

        [TestMethod]
        public void Mapper_MapTo_Generic_NoAliases()
        {
            args = new[] { "--String", "foo", "--Integer", "1", "--Long", "123456789", "--Double", "3.14", "--Boolean", "true", "--Flag" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.String);
            Assert.AreEqual(1, mapped.Integer);
            Assert.AreEqual(123456789, mapped.Long);
            Assert.AreEqual(3.14, mapped.Double);
            Assert.IsTrue(mapped.Boolean);
            Assert.IsTrue(mapped.Flag);
        }

        [TestMethod]
        public void Mapper_MapTo_Generic_WithAliases()
        {
            args = new[] { "--s", "foo", "--i", "1", "--l", "123456789", "--d", "3.14", "--b", "true", "--f" };

            var aliases = new Dictionary<string, string>
            {
                {"s", "String"},
                {"i", "Integer"},
                {"l", "Long"},
                {"d", "Double"},
                {"b", "Boolean"},
                {"f", "Flag"}
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases: aliases);

            Assert.AreEqual("foo", mapped.String);
            Assert.AreEqual(1, mapped.Integer);
            Assert.AreEqual(123456789, mapped.Long);
            Assert.AreEqual(3.14, mapped.Double);
            Assert.IsTrue(mapped.Boolean);
            Assert.IsTrue(mapped.Flag);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresBadKeys()
        {
            args = new[] { "--Foo", "bar" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresBadValues()
        {
	        args = new[] { "--Boolean", "1234" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsNotNull(mapped);
            Assert.IsFalse(mapped.Boolean);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresBadFlags()
        {
	        args = new[] { "--FooBar" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresUnPrefixedFlags()
        {
	        args = new[] { "Boolean", "true", "Flag" };

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsFalse(mapped.Boolean);
            Assert.IsFalse(mapped.Flag);
        }
    }
}
