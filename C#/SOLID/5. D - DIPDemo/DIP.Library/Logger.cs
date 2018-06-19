using System;

namespace DIP.Library
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: { message }");
        }
    }
}
