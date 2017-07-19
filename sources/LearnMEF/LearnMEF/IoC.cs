using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnMEF
{
    class IoC
    {
        private readonly CompositionContainer _container;

        public static IoC Instance
        {
            get { return Nested._instance; }
        }

        /// <summary>
        /// Load all types from the executing assembly
        /// </summary>
        private IoC()
        {
            AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            _container = new CompositionContainer(catalog);
            _container.ComposeParts(this);
        }

        /// <summary>
        /// Gets all the objects which are implementing T and which are exporting T attribute: [Export(typeof(T))]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Returns a collection of objects which are implementing T</returns>
        public IEnumerable<T> GetInstances<T>()
        {
            return _container.GetExportedValues<T>();
        }

        /// <summary>
        /// Gets the object which is implementing T and which has a specific contract name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contractName"></param>
        /// <returns></returns>
        public T GetInstance<T>(string contractName)
        {
            return _container.GetExportedValue<T>(contractName);
        }

        /// <summary>
        /// This is needed in order to use the _instance in a thread safe manner.
        /// </summary>
        private class Nested
        {
            static Nested()
            {

            }
            internal static readonly IoC _instance = new IoC();
        }
    }
}
