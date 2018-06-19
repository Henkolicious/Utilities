using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Library
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmout = 12.50M;
            Salary = baseAmout + (rank * 2);
        }
    }
}
