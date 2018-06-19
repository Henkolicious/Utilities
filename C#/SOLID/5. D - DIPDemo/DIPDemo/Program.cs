using System;
using DIP.Library;

namespace DIPDemo
{
    class Program
    {
        // SOLI[D] - Dependensie Inversion Principle
        // High level modual should not depend and low level modules.
        // - one should depend upon abstractions, not concretions.
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "John";
            owner.LastName = "Doe";
            owner.EmailAddress = "foo@bar.com";
            owner.PhoneNumber = "1234";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Water the flowers";
            chore.Owner = owner;

            chore.PreformedWork(3);
            chore.PreformedWork(1.5);
            chore.CompleteChore();

            Console.ReadKey();
        }
    }
}
