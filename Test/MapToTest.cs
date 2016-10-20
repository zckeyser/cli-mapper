using Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class MapToTest
    {
        private static readonly long LongValue = ((long) int.MaxValue + 1);
        private string[] args;

        private class TestOptions
        {
            public int IntField;

            public long LongField;

            public double DoubleField;

            public string StringField;

            public bool BooleanField;

            public bool FlagField;

            public int IntProperty { get; set; }
            public long LongProperty { get; set; }
            public double DoubleProperty { get; set; }
            public string StringProperty { get; set; }
            public bool BooleanProperty { get; set; }
            public bool FlagProperty { get; set; }
        }

        [TestInitialize]
        public void Initialize() { args = new string[0]; }

        [TestMethod]
        public void Mapper_MapTo_ReturnsObjectOfCorrectType()
        {
            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_StringField()
        {
			args = new[] { "--StringField", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringField);
        }

        [TestMethod]
        public void Mapper_MapTo_IntegerField()
        {
	        args = new[] { "--IntField", "1" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(1, mapped.IntField);
        }

        [TestMethod]
        public void Mapper_MapTo_LongField()
        {
	        args = new[] { "--LongField", "123456789" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(123456789, mapped.LongField);
        }

        [TestMethod]
        public void Mapper_MapTo_DoubleField()
        {
	        args = new[] { "--DoubleField", "3.14" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(3.14, mapped.DoubleField);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_KeyValueStyle()
        {
			args = new[] { "--BooleanField", "true" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.BooleanField);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_FlagStyle()
        {
	        args = new[] { "--FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_FlagStyle_WithFollowingArgs()
        {
            args = new[] { "--FlagField", "--StringField", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
            Assert.AreEqual("foo", mapped.StringField);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanField_FlagStyle_WithPrecedingArgs()
        {
            args = new[] { "--StringField", "foo", "--FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagField);
            Assert.AreEqual("foo", mapped.StringField);
        }

        [TestMethod]
        public void Mapper_MapTo_AllFieldValues()
        {
	        args = new[] { "--StringField", "foo", "--IntField", "1", "--LongField", "123456789", "--DoubleField", "3.14", "--BooleanField", "true", "--FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringField);
            Assert.AreEqual(1, mapped.IntField);
            Assert.AreEqual(123456789, mapped.LongField);
            Assert.AreEqual(3.14, mapped.DoubleField);
            Assert.IsTrue(mapped.BooleanField);
            Assert.IsTrue(mapped.FlagField);
        }

        [TestMethod]
        public void Mapper_MapTo_StringProperty()
        {
            args = new[] { "--StringProperty", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_IntegerProperty()
        {
            args = new[] { "--IntProperty", "1" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(1, mapped.IntProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_LongProperty()
        {
            args = new[] { "--LongProperty", "123456789" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(123456789, mapped.LongProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_DoubleProperty()
        {
            args = new[] { "--DoubleProperty", "3.14" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual(3.14, mapped.DoubleProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanProperty_KeyValueStyle()
        {
            args = new[] { "--BooleanProperty", "true" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.BooleanProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanProperty_FlagStyle()
        {
            args = new[] { "--FlagProperty" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanProperty_FlagStyle_WithFollowingArgs()
        {
            args = new[] { "--FlagProperty", "--StringProperty", "foo" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagProperty);
            Assert.AreEqual("foo", mapped.StringProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_BooleanProperty_FlagStyle_WithPrecedingArgs()
        {
            args = new[] { "--StringProperty", "foo", "--FlagProperty" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsTrue(mapped.FlagProperty);
            Assert.AreEqual("foo", mapped.StringProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_AllPropertyValues()
        {
            args = new[] { "--StringProperty", "foo", "--IntProperty", "1", "--LongProperty", "123456789", "--DoubleProperty", "3.14", "--BooleanProperty", "true", "--FlagProperty" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.AreEqual("foo", mapped.StringProperty);
            Assert.AreEqual(1, mapped.IntProperty);
            Assert.AreEqual(123456789, mapped.LongProperty);
            Assert.AreEqual(3.14, mapped.DoubleProperty);
            Assert.IsTrue(mapped.BooleanProperty);
            Assert.IsTrue(mapped.FlagProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_AllPropertyAndFieldValues()
        {
            args = new[] { "--StringField", "foo", "--IntField", "1", "--LongField", "123456789", "--DoubleField", "3.14", "--BooleanField", "true", "--FlagField", "--StringProperty", "foo", "--IntProperty", "1", "--LongProperty", "123456789", "--DoubleProperty", "3.14", "--BooleanProperty", "true", "--FlagProperty" };

            var mapped = Mapper.MapTo<TestOptions>(args);
            
            Assert.AreEqual("foo", mapped.StringField);
            Assert.AreEqual(1, mapped.IntField);
            Assert.AreEqual(123456789, mapped.LongField);
            Assert.AreEqual(3.14, mapped.DoubleField);
            Assert.IsTrue(mapped.BooleanField);
            Assert.IsTrue(mapped.FlagField);

            Assert.AreEqual("foo", mapped.StringProperty);
            Assert.AreEqual(1, mapped.IntProperty);
            Assert.AreEqual(123456789, mapped.LongProperty);
            Assert.AreEqual(3.14, mapped.DoubleProperty);
            Assert.IsTrue(mapped.BooleanProperty);
            Assert.IsTrue(mapped.FlagProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_Alias_StringField()
        {
            args = new[] { "--s", "foo" };

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
            args = new[] { "--i", "1" };

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
            args = new[] { "--l", LongValue.ToString() };

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
            args = new[] { "--d", "1.1" };

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
            args = new[] { "--b", "true" };

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
            args = new[] { "--f" };

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
            args = new[] { "--s", "foo" };

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
            args = new[] { "--i", "1" };

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
            args = new[] { "--l", LongValue.ToString() };

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
            args = new[] { "--d", "1.1" };

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
            args = new[] { "--b", "true" };

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
            args = new[] { "--f" };

            var aliases = new Dictionary<string, string>
            {
                { "f", "FlagProperty" }
            };

            var mapped = Mapper.MapTo<TestOptions>(args, aliases);

            Assert.IsTrue(mapped.FlagProperty);
        }

        [TestMethod]
        public void Mapper_MapTo_InvalidAlias()
        {
            args = new[] { "--s", "foo"};

            var badAliases = new Dictionary<string, string>
            {
                {"s", "FUBAR"}
            };

            var mapped = Mapper.MapTo<TestOptions>(args, badAliases);

            Assert.AreEqual(null, mapped.StringField);
        }

        [TestMethod]
        public void Mapper_MapTo_OutOfRangeInteger()
        {
            args = new[] { "--IntField",  };

            var mapped = Mapper.MapTo<TestOptions>(args);

            // should have not been set, and as such will be the default
            Assert.AreEqual(mapped.IntField, default(int));
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresBadKeys()
        {
            args = new[] { "--Foo", "bar" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresBadValues()
        {
	        args = new[] { "--BooleanField", "1234" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsNotNull(mapped);
            Assert.IsFalse(mapped.BooleanField);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresBadFlags()
        {
	        args = new[] { "--FooBar" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsNotNull(mapped);
        }

        [TestMethod]
        public void Mapper_MapTo_IgnoresUnPrefixedFlags()
        {
	        args = new[] { "BooleanField", "true", "FlagField" };

            var mapped = Mapper.MapTo<TestOptions>(args);

            Assert.IsFalse(mapped.BooleanField);
            Assert.IsFalse(mapped.FlagField);
        }
    }
}
