using System.IO;

namespace TreeSurgeon.Core.Generators.Content
{
    public class DefaultDirectoryCopier : ICopyDirectories
    {
        #region ICopyDirectories Members

        public void CopyDirectory(string sourceDirectory, string targetDirectory)
        {
            var sourceDirectoryInfo = new DirectoryInfo(sourceDirectory);
            var targetDirectoryInfo = new DirectoryInfo(targetDirectory);

            if (targetDirectoryInfo.Exists)
            {
                targetDirectoryInfo.Create();
            }
            foreach (var sourceChildDirectory in sourceDirectoryInfo.GetDirectories())
            {
                var targetChildDirectory = targetDirectoryInfo.CreateSubdirectory(sourceChildDirectory.Name);
                CopyDirectory(sourceChildDirectory.FullName, targetChildDirectory.FullName);
            }
            foreach (var sourceFile in sourceDirectoryInfo.GetFiles())
            {
                sourceFile.CopyTo(Path.Combine(targetDirectoryInfo.FullName, sourceFile.Name));
            }
        }

        #endregion
    }
}