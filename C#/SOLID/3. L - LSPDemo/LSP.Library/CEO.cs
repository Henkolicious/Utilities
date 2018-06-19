using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Library
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }

        public void GeneratePerformaceReview()
        {
            Console.WriteLine(@"I'm reviewing a direct report's performance.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're fired!");
        }
    }
}
