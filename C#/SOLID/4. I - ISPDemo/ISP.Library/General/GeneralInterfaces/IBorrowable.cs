using System;

namespace ISP.Library
{
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }


        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
