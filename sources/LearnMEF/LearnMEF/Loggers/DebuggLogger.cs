using System.ComponentModel.Composition;
using System.Diagnostics;

namespace LearnMEF
{
    [Export(typeof(ILogger))]
    class DebuggLogger : ILogger
    {
        public void Write(string message)
        {
            Debug.WriteLine(message);
        }
    }
}