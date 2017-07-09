using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace IntroToMEF
{
    public class HostMEFInApplication
    {
        [Import]
        public ILogger Logger { get; set; }

        internal void Run()
        {
            Compose();
            Logger.Write("My Message");
        }

        private void Compose()
        {
            var container = new CompositionContainer();
            container.ComposeParts(this,new ConsoleLogger());
        }
    }
}
