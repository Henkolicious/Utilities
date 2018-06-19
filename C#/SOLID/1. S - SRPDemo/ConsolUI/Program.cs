using SRP.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolUI
{
    class Program
    {
        // [S]OLID - Single Responsibility Principle
        // - a class should have only a single responsibility
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            IPerson user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
            }

            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}
