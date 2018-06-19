using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Library
{
    public interface IManager : IEmployee
    {
        void GeneratePerformaceReview();
    }
}
