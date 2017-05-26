using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using LearnMEF.Loggers;

namespace LearnMEF.Hosts
{
    [Export(typeof(IHost))]
    [Export("single", typeof(IHost))]
    public class SingleImport : IHost
    {

        public SingleImport()
        {
            
        }

        private ILogger _logger;

        //[Import]
        public ILogger Logger 
        {
            get { return _logger; }
            set { _logger = value; }
        } 

        public void Run()
        {
            //Compose();

            Logger.Write("This is a message.");
        }
    }
}