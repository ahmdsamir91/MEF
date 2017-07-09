using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToMEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //var host =new HostMEFInApplication();
            var host = new UsingAssemblyCatalog();
            host.Run();
        }
    }
}
