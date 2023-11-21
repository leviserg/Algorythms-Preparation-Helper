using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.TwoPointers
{
    public class CountBoundedSlices
    {
        public int getCountBoundedSlices(int K, int[] A)
        {

            int N = A.Length;
            int result = 0;
            int left = 0;
            int right = 0;
            int max = A[0];
            int min = A[0];

            while (right < N)
            {
                max = Math.Max(max, A[right]);
                min = Math.Min(min, A[right]);

                if (max - min <= K)
                {
                    result += (right - left + 1);
                    right++;
                }
                else
                {
                    left++;
                    if (left > right)
                    {
                        right = left;
                        max = A[left];
                        min = A[left];
                    }
                }

                if (result > 1_000_000_000)
                {
                    return 1_000_000_000;
                }
            }

            return result;


            /*
            int N = A.Length;
            int result = 0;
            int left = 0;
            int right = 0;
            int max = A[0];
            int min = A[0];

            for (left = 0; left < N; left++)
            {
                max = A[left];
                min = A[left];

                for (right = left; right < N; right++)
                {
                    max = Math.Max(max, A[right]);
                    min = Math.Min(min, A[right]);

                    if (max - min <= K)
                    {
                        result++;
                    }
                    else
                    {
                        break; // Break the inner loop, as further slices won't be valid.
                    }

                    if (result > 1_000_000_000)
                    {
                        return 1_000_000_000;
                    }
                }
            }

            return result;*/
        }
    }
}
