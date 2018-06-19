using ISP.Library; // Fictive physical Library
using System;
using System.Collections.Generic;

namespace ISPDemo
{
    class Program
    {
        // SOL[I]D - Interface Segregation Principle
        // Classes should not depend on interfaces they don't use.
        // - Break interfaces down to smaller pieces.
        // - Make the program more modular.
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD {
                Actors = new List<string> { "Lisa", "Ann", "John" },
                BorrowDate = DateTime.Now,
                Borrower = "John Doe",
                CheckOutDurationInDays = 4,
                LibraryId = new Guid().ToString(),
                RuntimeInMinutes = 114,
                Title = "Aliens"
            };            
        }
    }
}
