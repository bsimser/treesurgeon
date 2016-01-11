using System;
using System.IO;
using NUnit.Framework;
using TreeSurgeon.Core;

namespace TreeSurgeon.UnitTests.Core
{
    [TestFixture]
    public class SimpleDirectoryBuilderTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            Teardown();
        }

        [TearDown]
        public void Teardown()
        {
            if (Directory.Exists("myDir"))
            {
                Directory.Delete("myDir");
            }
        }

        #endregion

        [Test]
        public void ShouldCreateDirectoryAndReturnFullPath()
        {
            new SimpleDirectoryBuilder().CreateDirectory("myDir");

            Assert.IsTrue(Directory.Exists("myDir"));
        }

        [Test]
        public void ShouldThrowExceptionIfDirectoryAlreadyExists()
        {
            Directory.CreateDirectory("myDir");

            try
            {
                new SimpleDirectoryBuilder().CreateDirectory("myDir");
                Assert.Fail("Should throw exception");
            }
            catch (ApplicationException e)
            {
                Assert.AreNotEqual("", e.Message);
            }
        }
    }
}