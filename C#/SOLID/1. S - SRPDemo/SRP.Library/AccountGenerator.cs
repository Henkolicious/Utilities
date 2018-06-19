using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Library
{
    public class AccountGenerator
    {
        public static void CreateAccount(IPerson user)
        {
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
