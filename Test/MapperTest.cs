using ArgMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class MapperTest
    {
        List<string> args;

        [TestInitialize]
        public void Initialize()
        {
            args = new List<string>();
        }

        [TestMethod]
        public void Mapper_CreatesMap_AllStrings()
        {
            args.Add("--a");
            args.Add("foo");
            args.Add("--b");
            args.Add("bar");

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual("foo", map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual("bar", map["b"]);
        }

        [TestMethod]
        public void Mapper_CreatesMap_AllInts()
        {
            args.Add("--a");
            args.Add("1");
            args.Add("--b");
            args.Add("2");

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(1, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(2, map["b"]);
        }

        [TestMethod]
        public void Mapper_CreatesMap_AllDoubles()
        {
            args.Add("--a");
            args.Add("1.1");
            args.Add("--b");
            args.Add("2.2");

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(1.1, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(2.2, map["b"]);
        }

        [TestMethod]
        public void Mapper_CreatesMap_AllLong()
        {
            long a = (long)int.MaxValue + 1;
            long b = (long)int.MaxValue + 2;

            args.Add("--a");
            args.Add(a.ToString());
            args.Add("--b");
            args.Add(b.ToString());

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(a, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(b, map["b"]);
        }

        [TestMethod]
        public void Mapper_CreatesMap_AlternatePrefix()
        {
            args.Add("_a");
            args.Add("1");
            args.Add("_b");
            args.Add("2");

            var map = Mapper.Map(args, "_");

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(1, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(2, map["b"]);
        }
    }
}
