using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;

namespace TreeSurgeon.Core.Utils
{
    public class ProcessInfo
    {
        private const int DEFAULT_TIMEOUT = 120000;
        public const int INFINITE_TIMEOUT = 0;

        private readonly ProcessStartInfo _startInfo = new ProcessStartInfo();
        private string _standardInputContent;
        private int _timeout = DEFAULT_TIMEOUT;

        public ProcessInfo(string filename) : this(filename, null)
        {
        }

        public ProcessInfo(string filename, string arguments) : this(filename, arguments, null)
        {
        }

        public ProcessInfo(string filename, string arguments, string workingDirectory)
        {
            _startInfo.FileName = filename;
            _startInfo.Arguments = arguments;
            if (workingDirectory != null)
            {
                _startInfo.WorkingDirectory = new DirectoryInfo(workingDirectory).FullName;
            }
            _startInfo.UseShellExecute = false;
            _startInfo.CreateNoWindow = true;
            _startInfo.RedirectStandardOutput = true;
            _startInfo.RedirectStandardError = true;
            _startInfo.RedirectStandardInput = false;
            repathExecutableIfItIsInWorkingDirectory();
        }

        public StringDictionary EnvironmentVariables
        {
            get { return _startInfo.EnvironmentVariables; }
        }

        public string FileName
        {
            get { return _startInfo.FileName; }
        }

        public string Arguments
        {
            get { return _startInfo.Arguments; }
        }

        public string WorkingDirectory
        {
            get { return _startInfo.WorkingDirectory; }
        }

        public string StandardInputContent
        {
            get { return _standardInputContent; }
            set
            {
                _startInfo.RedirectStandardInput = true;
                _startInfo.UseShellExecute = false;
                _standardInputContent = value;
            }
        }

        public int TimeOut
        {
            get { return _timeout; }
            set { _timeout = (value == INFINITE_TIMEOUT) ? 0x7fffffff : value; }
        }

        private void repathExecutableIfItIsInWorkingDirectory()
        {
            if (WorkingDirectory != null)
            {
                var exectubleInWorkingDirectory = Path.Combine(WorkingDirectory, FileName);
                if (File.Exists(exectubleInWorkingDirectory))
                {
                    _startInfo.FileName = exectubleInWorkingDirectory;
                }
            }
        }

        public Process CreateProcess()
        {
            var process = new Process();
            process.StartInfo = _startInfo;
            return process;
        }

        public override bool Equals(object obj)
        {
            var otherProcessInfo = obj as ProcessInfo;
            if (otherProcessInfo == null)
            {
                return false;
            }

            return (FileName == otherProcessInfo.FileName
                    && Arguments == otherProcessInfo.Arguments
                    && WorkingDirectory == otherProcessInfo.WorkingDirectory
                    && StandardInputContent == otherProcessInfo.StandardInputContent);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return
                string.Format(
                    "FileName: [{0}] -- Arguments: [{1}] -- WorkingDirectory: [{2}] -- StandardInputContent: [{3}] ",
                    FileName, Arguments, WorkingDirectory, StandardInputContent);
        }
    }
}