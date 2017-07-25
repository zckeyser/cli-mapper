using CLIMapper;
using NUnit.Framework;

namespace Test.MapTo
{
    [TestFixture]
    public class MapToGeneralTests
    {
        [Test]
        public void Mapper_MapTo_ReturnsObjectOfCorrectType()
        {
            var mapped = Mapper.MapTo<TestOptions>(new string[0]);

            Assert.IsNotNull(mapped);
        }
    }
}
