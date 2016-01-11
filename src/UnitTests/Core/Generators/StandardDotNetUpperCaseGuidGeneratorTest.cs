using NUnit.Framework;
using TreeSurgeon.Core.Generators;

namespace TreeSurgeon.UnitTests.Core.Generators
{
    [TestFixture]
    public class StandardDotNetUpperCaseGuidGeneratorTest
    {
        [Test]
        public void ShouldProduceUpperCaseUniqueGUIDs()
        {
            var generator = new StandardDotNetUpperCaseGuidGenerator();
            var guid1 = generator.GenerateGuid();
            var guid2 = generator.GenerateGuid();

            Assert.AreNotEqual(guid1, guid2);
            Assert.AreEqual(guid1, guid1.ToUpper());
        }
    }
}