using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AdaptiveConsole;
using TreeSurgeon.Core;

namespace TreeSurgeonConsoleApplication
{
    [OptionContract(
        Type = ContractType.Patternized,
        Description = "Generates a new .NET development tree for a given project name.")]
    public class TreeSurgeonCommandsContract : OptionContractBase
    {
        [Option(
            Type = OptionType.SingleValue,
            Name = "/p;/project",
            Required = true,
            Description = "Specifies the project name.\r\n\t" +
                          "Please note - project name must not contain spaces.\r\n\t" +
                          "We recommend you use CamelCase for project names.")]
        public string ProjectName { get; set; }

        [Option(
            Type = OptionType.SingleValue,
            Name = "/v;/version", 
            Required = false, 
            Default = "2008",
            Description = "Specifies the Visual Studio version to generate.\r\n\t" +
                          "Valid options are: \"2003\", \"2005\", or \"2008\"\r\n\t" +
                          "Default is \"2008\"")]
        public string Version { get; set; }

        [Option(
            Type = OptionType.Switch,
            Name = "/nologo",
            Description = "When turned on, the logo and description\r\n\t" + 
                          "information will not be displayed.")]
        public bool NoLogo { get; set; }

        [Option(
            Type = OptionType.Switch, 
            Name = "/overwrite", 
            Description = "When turned on, any project with the same name\r\n\t" +
                  "will be deleted.")]
        public bool Overwrite { get; set; }

        [Option(
            Type = OptionType.SingleValue, 
            Name = "/t;/test", 
            Required = false, 
            Default = "NUnit",
            CaseSensitive = true,
            Description = "Specifies the Unit Test framework to use when generating the tree.\r\n\t" +
                  "Valid options are: \"NUnit\", or \"MbUnit\"\r\n\t" +
                  "Default is \"NUnit\"")]
        public string UnitTestFramework { get; set; }

        public override void Execute(ConsoleApplicationBase consoleApplication, IList<ArgumentInfo> args)
        {
            var options = from arg in args
                        where arg.Type == ArgumentType.Option
                        select arg;

            if(options.Count() < 1 || string.IsNullOrEmpty(ProjectName))
            {
                consoleApplication.PrintHelpMessage();
                return;
            }

            if(!NoLogo)
            {
                consoleApplication.PrintLogo();
            }

            Console.WriteLine("Starting Tree Generation{0}", Environment.NewLine);
            
            Console.WriteLine("       Project Name: \"{0}\"", ProjectName);
            Console.WriteLine("            Version: \"{0}\"", Version);
            Console.WriteLine("Unit Test Framework: \"{0}\"", UnitTestFramework);
            
            Console.WriteLine();

            var frontEnd = new TreeSurgeonFrontEnd(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Version);

            if(Overwrite)
            {
                Directory.Delete(frontEnd.GetOutputPath(ProjectName), true);
            }

            var outputDirectory = frontEnd.GenerateDevelopmentTree(ProjectName, UnitTestFramework);
            Console.WriteLine("Tree Generation complete.{0}{0}Files can be found at:{0}\"{1}\"", Environment.NewLine, outputDirectory);
        }
    }
}