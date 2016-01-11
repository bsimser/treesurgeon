using System;
using AdaptiveConsole;

namespace TreeSurgeon.TreeSurgeonConsole
{
    internal class TreeSurgeonConsoleMain
    {
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                ConsoleApplicationManager.RunApplication(args);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unhandled Exception thrown. Details follow:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}