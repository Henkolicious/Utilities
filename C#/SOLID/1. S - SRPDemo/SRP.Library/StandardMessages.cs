using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Library
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine(@"Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.Write("Press any key to close...");
            Console.ReadKey();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}
