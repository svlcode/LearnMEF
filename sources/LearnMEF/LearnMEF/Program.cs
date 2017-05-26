using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMEF
{
    class Program
    {
        static void Main(string[] args)
        {

            //HostMefInAnApplication mef = new HostMefInAnApplication();
            //mef.Run();

            UsingAnAssemblyCatalog app = new UsingAnAssemblyCatalog();
            app.Run();
        }

        
    }
}
