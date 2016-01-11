namespace TreeSurgeon.Core
{
    public interface IGenerateSolutionTrees
    {
        void Generate(string projectName, string outputPath, string resourceBasePath, string unitTestName);
    }
}