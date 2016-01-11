using System;
using System.IO;
using System.Threading;

namespace TreeSurgeon.Core.Utils
{
    /// <summary>
    /// ProcessReader asynchronously reads from the supplied TextReader stream.  The output of the stream is stored
    /// in the Output property.  The ProcessReader needs to operate in a separate thread, otherwise if the stream filled while
    /// the thread is blocked waiting for the process to exit, deadlock will occur.
    /// The ProcessReader implements IDisposable to ensure that the thread will be terminated and the stream will be closed when
    /// the reader goes out of scope.
    /// </summary>
    public class ProcessReader : IDisposable
    {
        private readonly TextWriter _output;
        private readonly TextReader _stream;
        private readonly Thread _thread;

        public ProcessReader(TextReader stream)
        {
            _stream = stream;
            _output = new StringWriter();
            _thread = new Thread(readToEnd);
            _thread.Priority = ThreadPriority.BelowNormal;
            _thread.Start();
        }

        public string Output
        {
            get { return _output.ToString(); }
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            _thread.Abort();
            WaitForExit();
        }

        #endregion

        public void WaitForExit()
        {
            _thread.Join();
            _stream.Close();
        }

        /// <summary>
        /// StreamReader.Peek() does not detect if there are no more characters in the buffer and the stream is blocked.
        /// It will return -1 if the buffer has been read, without checking if the stream is blocked.
        /// Hence, you can't rely on Peek() to determine if the end of the stream has been reached.
        /// </summary>
        private void readToEnd()
        {
            string nextLine;
            while ((nextLine = _stream.ReadLine()) != null)
            {
                _output.WriteLine(nextLine);
            }
        }
    }
}