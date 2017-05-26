using System;
using System.ComponentModel.Composition;

namespace LearnMEF.Loggers
{
    [Export(typeof(ILogger))]
    [Export("random", typeof(ILogger))]
    internal class SomeRandomLogger : ILogger
    {
        public SomeRandomLogger()
        {
            
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}