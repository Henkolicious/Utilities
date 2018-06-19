using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Library
{
    public class PersonDataCapture
    {
        public static IPerson Capture()
        {
            IPerson output = new Person();

            Console.Write(@"What is your first name: ");
            output.FirstName = Console.ReadLine();

            Console.Write(@"What is your last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
