using NUnit.Framework;
using TreeSurgeon.Core.Generators.Content;

namespace TreeSurgeon.UnitTests.Core.Generators.Content
{
    [TestFixture]
    public class DefaultVelocityTransformerConfigTest
    {
        [Test]
        public void ShouldEvaluateAConfigWithTheSamePropertiesAsEqual()
        {
            var config1 = new DefaultVelocityTransformerConfig("mydir");
            var config2 = new DefaultVelocityTransformerConfig("mydir");

            Assert.IsTrue(config1.Equals(config2));

            var config3 = new DefaultVelocityTransformerConfig("anotherdir");
            Assert.IsFalse(config1.Equals(config3));
        }

        [Test]
        public void ShouldReturnTemplateDirectoryAsThatPassedInConstructor()
        {
            var config = new DefaultVelocityTransformerConfig("mydir");
            Assert.AreEqual("mydir", config.TemplateDirectory);
        }
    }
}