namespace TreeSurgeon.Core.Utils
{
    /// <summary>
    /// ProcessResult holds the results of a Process' execution.  This class is returned from the ProcessExecutor
    /// once the Process has finished executing (teriminating either normally or abnormally).  
    /// ProcessResult indicates if the process executed successfully or if it timed out.
    /// It also indicates what the process wrote to its standard output and error streams.
    /// </summary>
    public class ProcessResult
    {
        public const int SUCCESSFUL_EXIT_CODE = 0;
        public const int TIMED_OUT_EXIT_CODE = -1;

        private readonly int _exitCode;
        private readonly string _standardError;
        private readonly string _standardOutput;
        private readonly bool _timedOut;

        public ProcessResult(string standardOutput, string standardError, int errorCode, bool timedOut)
        {
            _standardOutput = (standardOutput ?? string.Empty);
            _standardError = (standardError ?? string.Empty);
            _exitCode = errorCode;
            _timedOut = timedOut;
        }

        public string StandardOutput
        {
            get { return _standardOutput; }
        }

        public string StandardError
        {
            get { return _standardError; }
        }

        public int ExitCode
        {
            get { return _exitCode; }
        }

        public bool TimedOut
        {
            get { return _timedOut; }
        }

        /// <summary>
        /// A non-zero exit code is the best indication of a process' success or failure.  Not all applications adhere to this, however.
        /// Applications may write to stderr even if the process succeeds.
        /// </summary>
        public bool Failed
        {
            get { return _exitCode != SUCCESSFUL_EXIT_CODE; }
        }

        public bool HasErrorOutput
        {
            get { return _standardError.Trim() != string.Empty; }
        }
    }
}