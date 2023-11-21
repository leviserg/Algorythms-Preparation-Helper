using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises
{
    public static class EquilibriumArrayIndex
    {
        static int Equilibrium(int[] arr, int n)
        {
            // initialize sum of whole array
            int sum = 0;

            // initialize leftsum
            int leftsum = 0;

            /* Find sum of the whole array */
            for (int i = 0; i < n; ++i)
                sum += arr[i];

            for (int i = 0; i < n; ++i)
            {

                // sum is now right sum
                // for index i
                sum -= arr[i];

                if (leftsum == sum)
                    return i;

                leftsum += arr[i];
            }

            /* If no equilibrium index found,
            then return 0 */
            return -1;
        }
    }
}
