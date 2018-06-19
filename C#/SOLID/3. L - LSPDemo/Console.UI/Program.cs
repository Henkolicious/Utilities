using LSP.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        // SO[L]ID - Liskovs Substitution Principle.
        // If S is subtype of T => T can be replaced with S, without breaking the program.
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager
            {
                FirstName = "John",
                LastName = "Doe",                
            };
            accountingVP.CalculatePerHourRate(4);

            // IManager is a subtype of Employee => Employee can be replaced with IManager, without breaking the program.
            IManaged emp = new Employee {
                FirstName = "Manager",
                LastName = "Johnsson"
            };
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.ReadKey();
        }
    }
}
