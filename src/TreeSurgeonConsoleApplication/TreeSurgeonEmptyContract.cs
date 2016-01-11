using System.Collections.Generic;
using AdaptiveConsole;

namespace TreeSurgeonConsoleApplication
{
    [OptionContract(
        Type = ContractType.None,
        Description = "Prints the help information on the screen.")]
    public class TreeSurgeonEmptyContract : OptionContractBase
    {
        public override void Execute(ConsoleApplicationBase consoleApplication, IList<ArgumentInfo> args)
        {
            consoleApplication.PrintHelpMessage();
        }
    }
}