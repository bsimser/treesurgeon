using System.Collections;

namespace TreeSurgeon.Core.Generators.Content
{
    public interface IGenerateFiles
    {
        void Generate(string outputDirectory, string transformName, Hashtable transformParameters);
    }
}