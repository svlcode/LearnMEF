using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using LearnMEF.Loggers;

namespace LearnMEF.Hosts
{
    [Export(typeof(IHost))]
    [Export("specific", typeof(IHost))]
    public class ImportSpecificType : IHost
    {
        [Import("debug", typeof (ILogger))]
        public ILogger MyLogger { get; set; }


        public ImportSpecificType()
        {
            
        }

        public void Run()
        {
            MyLogger.Write("Test");
        }
    }
}