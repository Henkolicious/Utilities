using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Library
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmout = 19.75M;
            Salary = baseAmout + (rank * 4);
        }

        public void GeneratePerformaceReview()
        {
            // Simulation
            Console.WriteLine(@"I'm reviewing a direct report's preformance.");
        }
    }
}
