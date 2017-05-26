using System.ComponentModel.Composition;
using System.Diagnostics;

namespace LearnMEF.Loggers
{
    [Export(typeof(ILogger))]
    [Export("debug", typeof(ILogger))]
    class DebuggLogger : ILogger
    {

        public DebuggLogger()
        {
            
        }

        public void Write(string message)
        {
            Debug.WriteLine(message);
        }
    }
}