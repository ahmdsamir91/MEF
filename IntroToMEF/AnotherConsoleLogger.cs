using System;
using System.ComponentModel.Composition;

namespace IntroToMEF
{
    [Export(typeof(ILogger))]
    internal class AnotherConsoleLogger : ILogger
    {
        public AnotherConsoleLogger()
        {
        }

        public void Write(string Message)
        {
            Console.WriteLine("From AnotherConsoleLogger {0}", Message);
        }

    }
}