using System;
using System.ComponentModel.Composition;

namespace LearnMEF
{
    [Export(typeof(ILogger))]
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