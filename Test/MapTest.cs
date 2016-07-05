using Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class MapTest
    {
        List<string> args;

        [TestInitialize]
        public void Initialize()
        {
            args = new List<string>();
        }

        [TestMethod]
        public void Mapper_Map_AllStrings()
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
        public void Mapper_Map_AllBooleans()
        {
            args.Add("--a");
            args.Add("true");
            args.Add("--b");
            args.Add("false");

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(true, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(false, map["b"]);
        }

        [TestMethod]
        public void Mapper_Map_AllInts()
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
        public void Mapper_Map_AllDoubles()
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
        public void Mapper_Map_AllLong()
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
        public void Mapper_Map_MixedTypes()
        {
            long e = (long)int.MaxValue + 1;
            args.Add("--a");
            args.Add("foo");
            args.Add("--b");
            args.Add("true");
            args.Add("--c");
            args.Add("1");
            args.Add("--d");
            args.Add("1.1");
            args.Add("--e");
            args.Add(e.ToString());

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual("foo", map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(true, map["b"]);

            Assert.IsTrue(map.ContainsKey("c"));
            Assert.AreEqual(1, map["c"]);

            Assert.IsTrue(map.ContainsKey("d"));
            Assert.AreEqual(1.1, map["d"]);

            Assert.IsTrue(map.ContainsKey("e"));
            Assert.AreEqual(e, map["e"]);
        }

        [TestMethod]
        public void Mapper_Map_AlternatePrefix()
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
