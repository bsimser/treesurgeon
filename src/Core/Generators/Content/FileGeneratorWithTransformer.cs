using System;
using System.Collections;
using System.IO;

namespace TreeSurgeon.Core.Generators.Content
{
    public class FileGeneratorWithTransformer : IGenerateFiles
    {
        private readonly ITransformFiles _fileTransformer;

        public FileGeneratorWithTransformer(ITransformFiles transformFiles)
        {
            _fileTransformer = transformFiles;
        }

        #region IGenerateFiles Members

        public void Generate(string outputFileName, string transformName, Hashtable transformParameters)
        {
            if (File.Exists(outputFileName))
            {
                throw new ApplicationException(string.Format("Did not expect file [{0}] to already exist",
                                                             outputFileName));
            }

            var outputDir = Path.GetDirectoryName(outputFileName);
            if (! Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            using (var writer = File.CreateText(outputFileName))
            {
                writer.WriteLine(_fileTransformer.Transform(transformName, transformParameters));
                writer.Close();
            }
        }

        #endregion
    }
}