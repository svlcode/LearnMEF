using System.Collections.Generic;
using System.ComponentModel.Composition;
using LearnMEF.Loggers;

namespace LearnMEF.Hosts
{
    [Export(typeof(IHost))]
    [Export("many",typeof (IHost))]
    public class ImportMany: IHost
    {
        [ImportMany(typeof(ILogger))]
        public IEnumerable<ILogger> Loggers { get; set; }

        public ImportMany()
        {
            
        }

        public void Run()
        {
            foreach (var logger in Loggers)
            {
                logger.Write("Hello");
            }
        }
    }
}