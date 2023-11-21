using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.LeetCode150
{
    public class GetSumWithoutAddSign
    {
        public int GetSum(int a, int b)
        {

            // return (int)Math.FusedMultiplyAdd(a, 1, b); // (x * y) + z - double

            return (new List<int> { a, b }).Sum();

            while (b != 0)
            {
                int temp = (a & b) << 1;
                a = a ^ b;
                b = temp;
            }
            return a;
        }
    }
}
