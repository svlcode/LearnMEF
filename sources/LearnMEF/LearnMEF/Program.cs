using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LearnMEF.Hosts;

namespace LearnMEF
{
    class Program
    {
        private readonly CompositionContainer _container;
        private Program()
        {
            AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            _container = new CompositionContainer(catalog);
            _container.ComposeParts(this);
        }

        private void Start()
        {
            var hosts = _container.GetExportedValues<IHost>();

            foreach (var host in hosts)
            {
                host.Run();
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        
    }
}
