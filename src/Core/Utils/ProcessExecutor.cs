using System;
using System.Diagnostics;

namespace TreeSurgeon.Core.Utils
{
    /// <summary>
    /// The ProcessExecutor executes a new <see cref="Process"/> using the properties specified in the input <see cref="ProcessInfo" />.
    /// ProcessExecutor is designed specifically to deal with processes that redirect the results of both
    /// the standard output and the standard error streams.  Reading from these streams is performed in
    /// a separate thread using the <see cref="ProcessReader"/> class, in order to prevent deadlock while 
    /// blocking on <see cref="Process.WaitForExit(int)"/>.
    /// If the process does not complete executing within the specified timeout period, the ProcessExecutor will attempt to kill the process.
    /// As process termination is asynchronous, the ProcessExecutor needs to wait for the process to die.  Under certain circumstances, 
    /// the process does not terminate gracefully after being killed, causing the ProcessExecutor to throw an exception.
    /// </summary>
    public class ProcessExecutor : IExecuteProcesses
    {
        private const int WAIT_FOR_KILLED_PROCESS_TIMEOUT = 5000;

        #region IExecuteProcesses Members

        public virtual ProcessResult Execute(ProcessInfo processInfo)
        {
            using (var process = Start(processInfo))
            {
                using (
                    ProcessReader standardOutput = new ProcessReader(process.StandardOutput),
                                  standardError = new ProcessReader(process.StandardError))
                {
                    WriteToStandardInput(process, processInfo);

                    var hasExited = process.WaitForExit(processInfo.TimeOut);
                    if (hasExited)
                    {
                        standardOutput.WaitForExit();
                        standardError.WaitForExit();
                    }
                    else
                    {
                        Kill(process, processInfo, standardOutput, standardError);
                    }
                    return new ProcessResult(standardOutput.Output, standardError.Output, process.ExitCode, ! hasExited);
                }
            }
        }

        #endregion

        private static Process Start(ProcessInfo processInfo)
        {
            var process = processInfo.CreateProcess();
            Log.Debug(string.Format(
                          "Attempting to start process [{0}] in working directory [{1}] with arguments [{2}]",
                          process.StartInfo.FileName, process.StartInfo.WorkingDirectory, process.StartInfo.Arguments));

            var isNewProcess = process.Start();
            if (! isNewProcess) Log.Debug("Reusing existing process...");

            return process;
        }

        private static void Kill(Process process, ProcessInfo processInfo, ProcessReader standardOutput,
                                 ProcessReader standardError)
        {
            Log.Warning(string.Format(
                            "Process timed out: {0} {1}.  Process id: {2}.  This process will now be killed.",
                            processInfo.FileName, processInfo.Arguments, process.Id));
            Log.Debug(string.Format("Process stdout: {0}", standardOutput.Output));
            Log.Debug(string.Format("Process stderr: {0}", standardError.Output));
            process.Kill();
            if (! process.WaitForExit(WAIT_FOR_KILLED_PROCESS_TIMEOUT))
                throw new Exception(
                    string.Format(
                        @"The killed process {0} did not terminate within the allotted timeout period {1}.  The process or one of its child processes may not have died.  This may create problems when trying to re-execute the process.  It may be necessary to reboot the server to recover.",
                        process.Id, WAIT_FOR_KILLED_PROCESS_TIMEOUT));
            Log.Warning(string.Format("The timed out process has been killed: {0}", process.Id));
        }

        private static void WriteToStandardInput(Process process, ProcessInfo processInfo)
        {
            if (process.StartInfo.RedirectStandardInput)
            {
                process.StandardInput.Write(processInfo.StandardInputContent);
                process.StandardInput.Flush();
                process.StandardInput.Close();
            }
        }
    }
}