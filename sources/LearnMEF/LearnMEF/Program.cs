using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LearnMEF.Hosts;
using ConsoleLib;

namespace LearnMEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AddMenuItem("Export multiple objects", () =>
            {
                var hosts = IoC.Instance.GetInstances<IHost>();

                foreach (var host in hosts)
                {
                    host.Run();
                }
            });

            menu.AddMenuItem("Export specific object with contract name", () =>
            {
                var singleImport = IoC.Instance.GetInstance<IHost>(contractName: "single");
                singleImport.Run();
            });

            menu.Show();
        }
    }
}
