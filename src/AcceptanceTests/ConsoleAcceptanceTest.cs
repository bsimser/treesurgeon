using System;
using System.IO;
using NUnit.Framework;
using TreeSurgeon.Core.Utils;

namespace TreeSurgeon.AcceptanceTests
{
    [TestFixture]
    public class ConsoleAcceptanceTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            projectName = "AcceptanceTestProject";
            outputPath =
                Path.Combine(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "TreeSurgeon"),
                    projectName);
            wd = new DirectoryInfo(Directory.GetCurrentDirectory());
        }

        [TearDown]
        public void Teardown()
        {
            try
            {
                // If at first you don't succeed...
                DeleteOutputDir();
            }
            catch (Exception)
            {
                // .. try again. (Stoopid windows file locking...)
                DeleteOutputDir();
            }
        }

        #endregion

        private string projectName;
        private string outputPath;
        private DirectoryInfo wd;

        private void DeleteOutputDir()
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }
        }

        private string RunNantAndCheckPasses(string nantArgs)
        {
            var nantResult = new ProcessExecutor().Execute(new ProcessInfo("go.bat", nantArgs, outputPath));
            var nantOutput = nantResult.StandardOutput;

            if (nantResult.ExitCode != 0)
            {
                Console.WriteLine("Go.bat failed");
                Console.WriteLine("** Standard out from go.bat: **");
                Console.WriteLine(nantOutput);
                Console.WriteLine("** End of Standard out from go.bat: **\n");
                Console.WriteLine("Standard err:");
                Console.WriteLine(nantResult.StandardError);
                Assert.Fail("Go.bat failed");
            }

            Assert.IsTrue(nantOutput.IndexOf("BUILD SUCCEEDED") > -1);
            return nantOutput;
        }

        private void RunTreeSurgeonAndCheckOK()
        {
            //TODO: We are passing in 2005 as the version. Need to test for other versions as they generate different output
            var TreeSurgeonResult =
                new ProcessExecutor().Execute(new ProcessInfo(Path.Combine(wd.Name, "TreeSurgeonConsole.exe"),
                                                              projectName + " 2005", wd.Parent.FullName));
            if (TreeSurgeonResult.ExitCode != 0)
            {
                Console.WriteLine("TreeSurgeon Console failed");
                Console.WriteLine("** Standard out from TreeSurgeon.exe: **");
                Console.WriteLine(TreeSurgeonResult.StandardOutput);
                Console.WriteLine("** End of Standard out from TreeSurgeon.exe: **\n");
                Console.WriteLine("Standard err:");
                Console.WriteLine(TreeSurgeonResult.StandardError);
                Assert.Fail("TreeSurgeon console app failed");
            }

            Assert.IsTrue(Directory.Exists(outputPath));
        }

        private void CheckFileExistsAndIsBiggerThan(string fileName, int fileSize)
        {
            var expectedLocation = Path.Combine(Path.Combine(outputPath, "build"), fileName);
            Assert.IsTrue(File.Exists(expectedLocation));
            Assert.IsTrue(new FileInfo(expectedLocation).Length > fileSize);
        }

        [Test]
        [Ignore("Broken after adding 2005/2008 support, needs to be fixed")]
        public void GeneratedTreeShouldGenerateDistributionFiles()
        {
            RunTreeSurgeonAndCheckOK();
            RunNantAndCheckPasses("full");
            CheckFileExistsAndIsBiggerThan(projectName + ".zip", 1000);
        }

        [Test]
        [Ignore("Broken after adding 2005/2008 support, needs to be fixed")]
        public void GeneratedTreeShouldRunNCoverForUnitTests()
        {
            RunTreeSurgeonAndCheckOK();
            RunNantAndCheckPasses("full");
            CheckFileExistsAndIsBiggerThan(Path.Combine("test-reports", "Coverage.xml"), 500);
        }

        [Test]
        [Ignore(
            "Currently only works in NAnt build - need some Post-Build script that is configuration dependent to set this up for VS use."
            )]
        public void ShouldGenerateADevelopmentTreeWithCorrectNameThatBuildsSuccessfullyAndCanBeCleaned()
        {
            RunTreeSurgeonAndCheckOK();

            var nantOutput = RunNantAndCheckPasses("");
            Console.WriteLine(nantOutput);
            Assert.IsTrue(nantOutput.IndexOf("[msbuild]   Building solution configuration \"AutomatedDebug|Any CPU\"") >
                          -1);
            Assert.IsTrue(nantOutput.IndexOf("Tests run: 1, Failures: 0") > -1);
            Assert.IsTrue(Directory.Exists(Path.Combine(outputPath, "build")));
            CheckFileExistsAndIsBiggerThan(Path.Combine("test-reports", "UnitTests.xml"), 500);
            RunNantAndCheckPasses("clean");
            Assert.IsFalse(Directory.Exists(Path.Combine(outputPath, "build")));
        }
    }
}