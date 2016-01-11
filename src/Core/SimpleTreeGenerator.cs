using System.Collections;
using System.IO;
using TreeSurgeon.Core.Generators;
using TreeSurgeon.Core.Generators.Content;

namespace TreeSurgeon.Core
{
    public class SimpleTreeGenerator : IGenerateSolutionTrees
    {
        private readonly ICopyDirectories _directoryCopier;
        private readonly IGenerateGuids _guidGenerator;
        private readonly IGenerateFiles _fileGenerator;

        public SimpleTreeGenerator(
            ICopyDirectories copyDirectories,
            IGenerateFiles generator,
            IGenerateGuids generateGuids)
        {
            _fileGenerator = generator;
            _guidGenerator = generateGuids;
            _directoryCopier = copyDirectories;
        }

        #region IGenerateSolutionTrees Members

        public void Generate(string projectName, string outputPath, string resourceBasePath, string unitTestName)
        {
            _directoryCopier.CopyDirectory(
                Path.Combine(
                    resourceBasePath, Path.Combine("resources", "skeleton")),
                outputPath);

            var velocityContext = new Hashtable();
            velocityContext["projectName"] = projectName;
            velocityContext["unitTest"] = unitTestName;
            velocityContext["nantDeleteClause"] = @"${directory::exists(build.dir)}";
            velocityContext["coreGuid"] = _guidGenerator.GenerateGuid();
            velocityContext["unitTestGuid"] = _guidGenerator.GenerateGuid();
            velocityContext["consoleGuid"] = _guidGenerator.GenerateGuid();

            Generate(outputPath, "go.bat", "go.bat", velocityContext);
            Generate(outputPath, projectName + ".build", "Sapling.build." + unitTestName, velocityContext);
            Generate(outputPath, "src\\" + projectName + ".sln", "Sapling.sln", velocityContext);
            Generate(outputPath, "src\\" + projectName + "Console\\" + projectName + "Console.csproj",
                     "SaplingConsole.csproj", velocityContext);
            Generate(outputPath, "src\\" + projectName + "Console\\" + "AssemblyInfo.cs", "AssemblyInfo.cs",
                     velocityContext);
            Generate(outputPath, "src\\" + projectName + "Console\\" + "HelloWorld.cs", "HelloWorld.cs", velocityContext);
            Generate(outputPath, "src\\Core\\" + "Core.csproj", "Core.csproj", velocityContext);
            Generate(outputPath, "src\\Core\\" + "AssemblyInfo.cs", "AssemblyInfo.cs", velocityContext);
            Generate(outputPath, "src\\UnitTests\\" + "UnitTests.csproj", "UnitTests.csproj", velocityContext);
            Generate(outputPath, "src\\UnitTests\\" + "AssemblyInfo.cs", "AssemblyInfo.cs", velocityContext);
            Generate(outputPath, "src\\UnitTests\\" + "Test1.cs", "Test1.cs", velocityContext);
        }

        #endregion

        private void Generate(string topPath, string childPath, string templateName, Hashtable velocityContext)
        {
            _fileGenerator.Generate(Path.Combine(topPath, childPath), templateName + ".vm", velocityContext);
        }
    }
}