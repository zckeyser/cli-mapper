using CLIMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.MapTo
{
    [TestClass]
    public class MapToGeneralTests
    {
        [TestMethod]
        public void Mapper_MapTo_ReturnsObjectOfCorrectType()
        {
            var mapped = Mapper.MapTo<TestOptions>(new string[0]);

            Assert.IsNotNull(mapped);
        }
    }
}
