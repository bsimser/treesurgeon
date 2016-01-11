using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace TreeSurgeon.Core.Utils
{
    public class Log
    {
        private static readonly TraceSwitch LogSwitch = new TreeSurgeonTraceSwitch();

        /// <summary>
        /// Utility type, not intended for instantiation.
        /// </summary>
        private Log()
        {
        }

        public static void Info(string message)
        {
            WriteLine("Info", message, LogSwitch.TraceInfo);
        }

        public static void Debug(string message)
        {
            WriteLine("Debug", message, LogSwitch.TraceVerbose);
        }

        public static void Warning(string message)
        {
            WriteLine("Warning", message, LogSwitch.TraceWarning);
        }

        public static void Warning(Exception ex)
        {
            WriteLine("Warning", ex, LogSwitch.TraceWarning);
        }

        public static void Error(string message)
        {
            WriteLine("Error", message, LogSwitch.TraceError);
        }

        public static void Error(Exception ex)
        {
            WriteLine("Error", ex, LogSwitch.TraceError);
        }

        private static string CreateExceptionMessage(Exception ex)
        {
            var buffer = new StringBuilder();
            buffer.Append(ex.Message).Append(Environment.NewLine);
            buffer.Append("----------").Append(Environment.NewLine);
            buffer.Append(ex.ToString()).Append(Environment.NewLine);
            buffer.Append("----------").Append(Environment.NewLine);
            return buffer.ToString();
        }

        private static string GetContextName()
        {
            return Thread.CurrentThread.Name ?? "Tree Surgeon";
        }

        private static void WriteLine(string level, Exception ex, bool traceSwitch)
        {
            WriteLine(level, CreateExceptionMessage(ex), traceSwitch);
        }

        private static void WriteLine(string level, string message, bool traceSwitch)
        {
            if (traceSwitch)
            {
                WriteLine(level, message);
            }
        }

        private static void WriteLine(string level, string message)
        {
            var category = string.Format("[{0}:{1}]", GetContextName(), level);
            Trace.WriteLine(message, category);
        }

        #region Nested type: TreeSurgeonTraceSwitch

        private class TreeSurgeonTraceSwitch : TraceSwitch
        {
            public TreeSurgeonTraceSwitch()
                : base("TreeSurgeonTraceSwitch", "TraceSwitch used for instrumenting Tree Surgeon")
            {
                if (Level == TraceLevel.Off)
                {
                    Level = TraceLevel.Error;
                }
            }
        }

        #endregion
    }
}