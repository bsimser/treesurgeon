using System;
using System.IO;
using NMock;
using NUnit.Framework;
using TreeSurgeon.Core;

namespace TreeSurgeon.UnitTests.Core
{
    [TestFixture]
    public class TreeSurgeonFrontEndTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            _mockDirectoryBuilder = new DynamicMock(typeof (IBuildDirectories));
            _mockGenerator = new DynamicMock(typeof (IGenerateSolutionTrees));
            _treeSurgeonApplicationDirectory = "treeSurgeonDirectory";

            _frontEnd = new TreeSurgeonFrontEnd((IBuildDirectories) _mockDirectoryBuilder.MockInstance,
                                                (IGenerateSolutionTrees) _mockGenerator.MockInstance,
                                                _treeSurgeonApplicationDirectory);
        }

        #endregion

        private TreeSurgeonFrontEnd _frontEnd;
        private DynamicMock _mockDirectoryBuilder;
        private DynamicMock _mockGenerator;
        private string _treeSurgeonApplicationDirectory;

        private void VerifyAll()
        {
            _mockDirectoryBuilder.Verify();
            _mockGenerator.Verify();
        }

        [Test]
        public void ShouldCreateDirectoryBuilderAndPassControlToGeneratorUsingMbUnit()
        {
            var expectedOutputPath =
                Path.Combine(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "TreeSurgeon"),
                    "newProject");

            _mockDirectoryBuilder.Expect("CreateDirectory", expectedOutputPath);
            _mockGenerator.Expect("Generate", "newProject", expectedOutputPath, "treeSurgeonDirectory", "MbUnit");

            var outputDirectory = _frontEnd.GenerateDevelopmentTree("newProject", "MbUnit");

            Assert.AreEqual(expectedOutputPath, outputDirectory);
            VerifyAll();
        }

        [Test]
        public void ShouldCreateDirectoryBuilderAndPassControlToGeneratorUsingNUnit()
        {
            var expectedOutputPath =
                Path.Combine(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "TreeSurgeon"),
                    "newProject");

            _mockDirectoryBuilder.Expect("CreateDirectory", expectedOutputPath);
            _mockGenerator.Expect("Generate", "newProject", expectedOutputPath, "treeSurgeonDirectory", "NUnit");

            var outputDirectory = _frontEnd.GenerateDevelopmentTree("newProject", "NUnit");

            Assert.AreEqual(expectedOutputPath, outputDirectory);
            VerifyAll();
        }
    }
}