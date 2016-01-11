using System;
using System.IO;
using TreeSurgeon.Core.Generators;
using TreeSurgeon.Core.Generators.Content;

namespace TreeSurgeon.Core
{
    public class TreeSurgeonFrontEnd
    {
        private readonly IBuildDirectories _buildDirectories;
        private readonly IGenerateSolutionTrees _generateSolutionTrees;
        private readonly string _treeSurgeonApplicationDirectory;

        public TreeSurgeonFrontEnd(
            IBuildDirectories buildDirectories,
            IGenerateSolutionTrees generateSolutionTrees,
            string treeSurgeonApplicationDirectory)
        {
            _buildDirectories = buildDirectories;
            _generateSolutionTrees = generateSolutionTrees;
            _treeSurgeonApplicationDirectory = treeSurgeonApplicationDirectory;
        }

        public TreeSurgeonFrontEnd(string treeSurgeonApplicationDirectory, string version) : this(
            new SimpleDirectoryBuilder(),
            new SimpleTreeGenerator(
                new DefaultDirectoryCopier(),
                new FileGeneratorWithTransformer(
                    new LazilyInitialisingVelocityTransformer(
                        new DefaultVelocityTransformerConfig(
                            Path.Combine(treeSurgeonApplicationDirectory, "Resources\\templates\\" + version)))
                    ),
                new StandardDotNetUpperCaseGuidGenerator()
                ), treeSurgeonApplicationDirectory)
        {
        }

        public string GenerateDevelopmentTree(string projectName, string unitTestName)
        {
            var outputPath = GetOutputPath(projectName);
            _buildDirectories.CreateDirectory(outputPath);
            _generateSolutionTrees.Generate(projectName, outputPath, _treeSurgeonApplicationDirectory, unitTestName);
            return outputPath;
        }

        public string GetOutputPath(string projectName)
        {
            return Path.Combine(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "TreeSurgeon"),
                projectName);
        }
    }
}