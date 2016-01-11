using System.Collections;
using System.IO;
using NMock;
using NUnit.Framework;
using TreeSurgeon.Core.Generators.Content;

namespace TreeSurgeon.UnitTests.Core.Generators.Content
{
    [TestFixture]
    public class LazilyInitialisingVelocityTransformerTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            Teardown();
            Directory.CreateDirectory("testtemplates");
            using (var writer = new StreamWriter(@"testtemplates\testtemplate.vm"))
            {
                writer.Write("foo is $foo");
                writer.Flush();
                writer.Close();
            }

            configurationMock = new DynamicMock(typeof (IConfigureTheTransformer));
            configurationMock.SetupResult("TemplateDirectory", "testtemplates");
            viewTransformer =
                new LazilyInitialisingVelocityTransformer((IConfigureTheTransformer) configurationMock.MockInstance);
        }

        [TearDown]
        public void Teardown()
        {
            if (File.Exists(@"testtemplates\testtemplate.vm"))
            {
                File.Delete(@"testtemplates\testtemplate.vm");
            }
            if (Directory.Exists("testtemplates"))
            {
                Directory.Delete("testtemplates");
            }
        }

        #endregion

        private LazilyInitialisingVelocityTransformer viewTransformer;
        private DynamicMock configurationMock;

        private void VerifyAll()
        {
            configurationMock.Verify();
        }

        [Test]
        public void ShouldUseVelocityToMergeContextContentsWithTemplate()
        {
            var contextContents = new Hashtable();
            contextContents["foo"] = "bar";

            Assert.AreEqual("foo is bar", viewTransformer.Transform("testtemplate.vm", contextContents));
            VerifyAll();
        }
    }
}