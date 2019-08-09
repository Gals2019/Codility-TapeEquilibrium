using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)

        {

            int[] A = {3,1,2,4,3};

            List<long> diffs = new List<long>();
            long left = 0;
            long sum = A.Sum();
            foreach (int item in A)
            {
                left += item;
                long calculo = (sum - left) - left;
                diffs.Add(Math.Abs(calculo));
            }
            return (int)diffs.Min();

        }
    }
}
