﻿using System;
using System.Collections.Generic;

namespace ISP.Library
{
    public class DVD : IBorrowableDVD
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public int CheckOutDurationInDays { get; set; }
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut(string borrower)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
