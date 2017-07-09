using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IntroToMEF
{
    class UsingAssemblyCatalog
    {
        [ImportMany]
        public IEnumerable<ILogger> Loggers { get; set; }

        public void Run()
        {
            Compose();
            foreach (var Logger in Loggers)
            {
                Logger.Write("hi");
            }
        }

        private void Compose()
        {
            // used to let mef discover all the exported classes in the assembly
            var assemblyCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            // container for the exported parts
            var container = new CompositionContainer(assemblyCatalog);
            // link the Import with the export parts
            container.ComposeParts(this);
        }
    }
}
