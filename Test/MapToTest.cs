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
        private List<string> args;

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
        public void Initialize()
        {
            args = new List<string>();
        }

        [TestMethod]
        public void Mapper_MapTo_ReturnsObjectOfCorrectType()
        {
            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_StringField()
        {
            args.Add("--String");
            args.Add("foo");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual("foo", mapped.String);
        }

        [TestMethod]
        public void Mapper_MapTo_IntegerField()
        {
            args.Add("--Integer");
            args.Add("1");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual(1, mapped.Integer);
        }

        [TestMethod]
        public void Mapper_MapTo_LongField()
        {
            args.Add("--Long");
            args.Add("123456789");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual(123456789, mapped.Long);
        }

        [TestMethod]
        public void Mapper_MapTo_DoubleField()
        {
            args.Add("--Double");
            args.Add("3.14");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.AreEqual(3.14, mapped.Double);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_KeyValueStyle()
        {
            args.Add("--Boolean");
            args.Add("true");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsTrue(mapped.Boolean);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_FlagStyle()
        {
            args.Add("--Flag");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsTrue(mapped.Flag);
        }

        [TestMethod]
        public void Mapper_MapTo_AllValues()
        {
            args.Add("--String");
            args.Add("foo");
            args.Add("--Integer");
            args.Add("1");
            args.Add("--Long");
            args.Add("123456789");
            args.Add("--Double");
            args.Add("3.14");
            args.Add("--Boolean");
            args.Add("true");
            args.Add("--Flag");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

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
            args.Add("--Foo");
            args.Add("bar");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresBadValues()
        {
            args.Add("--Boolean");
            args.Add("1234");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsNotNull(mapped);
            Assert.IsFalse(mapped.Boolean);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresBadFlags()
        {
            args.Add("--FooBar");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresUnPrefixedFlags()
        {
            args.Add("Boolean");
            args.Add("true");
            args.Add("Flag");

            var mapped = Mapper.MapTo(args, mappingType) as TestOptions;

            Assert.IsFalse(mapped.Boolean);
            Assert.IsFalse(mapped.Flag);
        }
    }
}
