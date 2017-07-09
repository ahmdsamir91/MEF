using System;
using System.ComponentModel.Composition;

namespace IntroToMEF
{
    [Export(typeof(ILogger))]
    internal class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
        }

        public void Write(string Message)
        {
            Console.WriteLine(Message);
        }

    }
}