using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace LearnMEF
{
    public class UsingAnAssemblyCatalog
    {
        [ImportMany]
        public IEnumerable<ILogger> Loggers { get; set; }

        [Import]
        public ILogger MyLogger { get; set; }

        internal void Run()
        {
            Compose();

            MyLogger.Write("Test"); 
            foreach (var logger in Loggers)
            {
                logger.Write("Hello");
            }
        }

        private void Compose()
        {
            
            var assemblyCatalog = new AssemblyCatalog(GetType().Assembly);

            var container = new CompositionContainer(assemblyCatalog);
            container.ComposeParts(this);
        }
    }
}