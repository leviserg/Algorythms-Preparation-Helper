using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises
{
    public static class BinaryGap
    {
        public static int GetBinaryGap(int N)
        {
            int last = -1, ans = 0;
            int maxIntValue = int.MaxValue;
            int maxBitNumber = (int)Math.Floor(Math.Log2(maxIntValue)) + 1;

            for (int i = 0; i < maxBitNumber; ++i)
            {
                
                if (((N >> i) & 1) > 0)
                {
                    Console.WriteLine(Convert.ToString(N >> i, 2) + " ## i = " + i.ToString() + ", last = " + last.ToString() + ", ans = " + ans.ToString());
                    if (last >= 0)
                        ans = Math.Max(ans, i - last - 1);
                    last = i;
                }
            }

            return ans;
        }

        public static int CountConformingIntegers(uint A, uint B, uint C)
        {
            // Initialize a counter for conforming integers
            int conformingCount = 0;

            // Iterate through all possible integers in the range [0, 1,073,741,823]
            for (uint i = 0; i <= 1_073_741_823U; i++)
            {
                // Check if i conforms to at least one of the three input integers
                if ((i & A) == A || (i & B) == B || (i & C) == C)
                {
                    conformingCount++;
                }
            }

            return conformingCount;
        }
    }
}
