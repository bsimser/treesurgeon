using System;
using System.Text;
using AdaptiveConsole;

namespace TreeSurgeonConsoleApplication
{
    public class TreeSurgeon : ConsoleApplicationBase
    {
        public TreeSurgeon(string[] args) : base(args)
        {
        }

        protected override string Logo
        {
            get
            {
                var sb = new StringBuilder();
                sb.AppendFormat("TreeSurgeon version 2.0{0}", Environment.NewLine);
                sb.AppendFormat("Copyright (C) 2007 - 2008 Bil Simser{0}", Environment.NewLine);
                sb.Append("Copyright (C) 2005 - 2006 Mike Roberts, ThoughtWorks, Inc.");
                return sb.ToString();
            }
        }

        protected override string Description
        {
            get { return "Creates a .NET development tree"; }
        }
    }
}