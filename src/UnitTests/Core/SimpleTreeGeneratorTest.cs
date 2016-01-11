using System.Collections;
using NMock;
using NUnit.Framework;
using ThoughtWorks.TreeSurgeon.UnitTests.TestUtils;
using TreeSurgeon.Core;
using TreeSurgeon.Core.Generators;
using TreeSurgeon.Core.Generators.Content;

namespace TreeSurgeon.UnitTests.Core
{
    [TestFixture]
    public class SimpleTreeGeneratorTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            directoryCopierMock = new DynamicMock(typeof (ICopyDirectories));
            velocityFileGeneratorMock = new DynamicMock(typeof (IGenerateFiles));
            guidGeneratorMock = new DynamicMock(typeof (IGenerateGuids));

            generator = new SimpleTreeGenerator((ICopyDirectories) directoryCopierMock.MockInstance,
                                                (IGenerateFiles) velocityFileGeneratorMock.MockInstance,
                                                (IGenerateGuids) guidGeneratorMock.MockInstance);
        }

        [TearDown]
        public void TearDown()
        {
        }

        #endregion

        private SimpleTreeGenerator generator;
        private DynamicMock velocityFileGeneratorMock;
        private DynamicMock directoryCopierMock;
        private DynamicMock guidGeneratorMock;

        private void VerifyAll()
        {
            velocityFileGeneratorMock.Verify();
            directoryCopierMock.Verify();
            guidGeneratorMock.Verify();
        }

        [Test]
        [Ignore]
        public void ShouldCopySkeletonAndCallVelocityFileGeneratorForEveryFile()
        {
            var expectedVelocityContext = new Hashtable();
            expectedVelocityContext["projectName"] = "NewTestProject";
            expectedVelocityContext["unitTestName"] = "NUnit";
            expectedVelocityContext["nantDeleteClause"] = @"${directory::exists(build.dir)}";
            expectedVelocityContext["coreGuid"] = "guid1";
            expectedVelocityContext["unitTestGuid"] = "guid2";
            expectedVelocityContext["consoleGuid"] = "guid3";

            // SETUP
            directoryCopierMock.Expect("CopyDirectory", "resourceBase\\resources\\skeleton", "output");

            guidGeneratorMock.ExpectAndReturn("GenerateGuid", "guid1");
            guidGeneratorMock.ExpectAndReturn("GenerateGuid", "guid2");
            guidGeneratorMock.ExpectAndReturn("GenerateGuid", "guid3");

            velocityFileGeneratorMock.Expect("Generate", @"output\go.bat", "go.bat.vm",
                                             new HashtableConstraint(expectedVelocityContext));
            velocityFileGeneratorMock.Expect("Generate", @"output\NewTestProject.build", "Sapling.build.nunit.vm",
                                             new HashtableConstraint(expectedVelocityContext));
            velocityFileGeneratorMock.Expect("Generate", @"output\src\NewTestProject.sln", "Sapling.sln.vm",
                                             new HashtableConstraint(expectedVelocityContext));

            velocityFileGeneratorMock.Expect("Generate",
                                             @"output\src\NewTestProjectConsole\NewTestProjectConsole.csproj",
                                             "SaplingConsole.csproj.vm",
                                             new HashtableConstraint(expectedVelocityContext));
            velocityFileGeneratorMock.Expect("Generate", @"output\src\NewTestProjectConsole\AssemblyInfo.cs",
                                             "AssemblyInfo.cs.vm", new HashtableConstraint(expectedVelocityContext));
            velocityFileGeneratorMock.Expect("Generate", @"output\src\NewTestProjectConsole\HelloWorld.cs",
                                             "HelloWorld.cs.vm", new HashtableConstraint(expectedVelocityContext));

            velocityFileGeneratorMock.Expect("Generate", @"output\src\Core\Core.csproj", "Core.csproj.vm",
                                             new HashtableConstraint(expectedVelocityContext));
            velocityFileGeneratorMock.Expect("Generate", @"output\src\Core\AssemblyInfo.cs", "AssemblyInfo.cs.vm",
                                             new HashtableConstraint(expectedVelocityContext));

            velocityFileGeneratorMock.Expect("Generate", @"output\src\UnitTests\UnitTests.csproj", "UnitTests.csproj.vm",
                                             new HashtableConstraint(expectedVelocityContext));
            velocityFileGeneratorMock.Expect("Generate", @"output\src\UnitTests\AssemblyInfo.cs", "AssemblyInfo.cs.vm",
                                             new HashtableConstraint(expectedVelocityContext));
            velocityFileGeneratorMock.Expect("Generate", @"output\src\UnitTests\Test1.cs", "Test1.cs.vm",
                                             new HashtableConstraint(expectedVelocityContext));

            // EXECUTE
            generator.Generate("NewTestProject", "output", "resourceBase", "NUnit");

            // VERIFY
            VerifyAll();
        }
    }
}