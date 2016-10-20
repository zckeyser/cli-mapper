using Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class MapTest
    {
	    private string[] args;

        [TestInitialize]
        public void Initialize()
        {
            args = new string[0];
        }

        [TestMethod]
        public void Mapper_Map_AllStrings()
        {
	        args = new[] {"--a", "foo", "--b", "bar"};

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual("foo", map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual("bar", map["b"]);
        }

        [TestMethod]
        public void Mapper_Map_AllBooleans()
        {
			args = new[] { "--a", "true", "--b", "false" };

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(true, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(false, map["b"]);
        }

        [TestMethod]
        public void Mapper_Map_AllInts()
        {
			args = new[] { "--a", "1", "--b", "2" };

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(1, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(2, map["b"]);
        }

        [TestMethod]
        public void Mapper_Map_AllDoubles()
        {
			args = new[] { "--a", "1.1", "--b", "2.2" };

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

			args = new[] { "--a", a.ToString(), "--b", b.ToString() };

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(a, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(b, map["b"]);
        }

        [TestMethod]
        public void Mapper_Map_LoneFlag()
        {
            args = new[] {"--flag"};

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("flag"));
            Assert.IsTrue((bool) map["flag"]);
        }

        [TestMethod]
        public void Mapper_Map_LoneFlagFollowedByFlag()
        {
            args = new[] {"--flag", "--s", "foo"};

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("flag"));
            Assert.IsTrue((bool) map["flag"]);

            Assert.IsTrue(map.ContainsKey("s"));
            Assert.AreEqual("foo", map["s"]);
        }

        [TestMethod]
        public void Mapper_Map_LoneFlagPrecededByOtherFlag()
        {
            args = new[] { "--s", "foo", "--flag" };

            var map = Mapper.Map(args);

            Assert.IsTrue(map.ContainsKey("flag"));
            Assert.IsTrue((bool)map["flag"]);

            Assert.IsTrue(map.ContainsKey("s"));
            Assert.AreEqual("foo", map["s"]);
        }

        [TestMethod]
        public void Mapper_Map_MixedTypes()
        {
            long e = (long)int.MaxValue + 1;

	        args = new[] { "--a", "foo", "--b", "true", "--c", "1", "--d", "1.1", "--e", e.ToString() };

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
	        args = new[] { "_a", "1", "_b", "2" };

            var map = Mapper.Map(args, "_");

            Assert.IsTrue(map.ContainsKey("a"));
            Assert.AreEqual(1, map["a"]);

            Assert.IsTrue(map.ContainsKey("b"));
            Assert.AreEqual(2, map["b"]);
        }
    }
}
