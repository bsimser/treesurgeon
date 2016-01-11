using System;
using System.IO;

namespace TreeSurgeon.Core
{
    public class SimpleDirectoryBuilder : IBuildDirectories
    {
        #region IBuildDirectories Members

        public void CreateDirectory(string directoryName)
        {
            if (Directory.Exists(directoryName))
            {
                throw new ApplicationException(
                    string.Format(
                        "Can't generate directory [{0}] since it already exists on disk. Wait until a later version, or delete the existing directory!",
                        directoryName));
            }

            Directory.CreateDirectory(directoryName);
        }

        #endregion
    }
}