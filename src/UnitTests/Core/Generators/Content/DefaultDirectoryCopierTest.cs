using System.IO;
using NUnit.Framework;
using TreeSurgeon.Core.Generators.Content;

namespace TreeSurgeon.UnitTests.Core.Generators.Content
{
    [TestFixture]
    public class DefaultDirectoryCopierTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            Teardown();
            directoryCopier = new DefaultDirectoryCopier();

            Directory.CreateDirectory("source");
            Directory.CreateDirectory(@"source\sub");
            CreateFile(@"source\file1");
            CreateFile(@"source\file2");
            CreateFile(@"source\sub\file3");
        }

        [TearDown]
        public void Teardown()
        {
            DeleteFileIfExists(@"source\file1");
            DeleteFileIfExists(@"source\file2");
            DeleteFileIfExists(@"source\sub\file3");
            DeleteDirectoryIfExists(@"source\sub");
            DeleteDirectoryIfExists(@"source");
            DeleteFileIfExists(@"myTarget\file1");
            DeleteFileIfExists(@"myTarget\file2");
            DeleteFileIfExists(@"myTarget\sub\file3");
            DeleteDirectoryIfExists(@"myTarget\sub");
            DeleteDirectoryIfExists(@"myTarget");
        }

        #endregion

        private DefaultDirectoryCopier directoryCopier;

        private static void CreateFile(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.Write(path);
                writer.Flush();
                writer.Close();
            }
        }

        private void AssertFileExistsAndContains(string path, string expectedContents)
        {
            Assert.IsTrue(File.Exists(path));
            using (var reader = new StreamReader(path))
            {
                Assert.AreEqual(expectedContents, reader.ReadToEnd());
            }
        }

        private void DeleteFileIfExists(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        private void DeleteDirectoryIfExists(string directory)
        {
            if (Directory.Exists(directory))
            {
                Directory.Delete(directory);
            }
        }

        [Test]
        public void ShouldCopyFilesFromSourceToTargetRecursively()
        {
            directoryCopier.CopyDirectory("source", "myTarget");
            AssertFileExistsAndContains(@"myTarget\file1", @"source\file1");
            AssertFileExistsAndContains(@"myTarget\file2", @"source\file2");
            AssertFileExistsAndContains(@"myTarget\sub\file3", @"source\sub\file3");
        }

        [Test]
        public void ShouldCreateOutputDirectoryIfItDoesntExist()
        {
            directoryCopier.CopyDirectory("source", "myTarget");
            Assert.IsTrue(Directory.Exists("myTarget"));
        }
    }
}