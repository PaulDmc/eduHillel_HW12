using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eduHillel_HW12
{
    public static class FibonacciCalculator
    {
        public static int CalculateFibonacci(int numb)
        {
                if (numb < 0)
                {
                    throw new ArgumentException("The number must be non-negative.");
                }

                if (numb == 0) return 0;
                if (numb == 1) return 1;

                return CalculateFibonacci(numb - 1) + CalculateFibonacci(numb - 2);
        }
    }
}
