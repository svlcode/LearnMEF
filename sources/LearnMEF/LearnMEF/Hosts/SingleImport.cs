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
        
        public void Run()
        {
            var logger = IoC.Instance.GetInstance<ILogger>("debug");
            logger.Write("This is a message.");
        }
    }
}