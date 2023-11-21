using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.TwoPointers
{
    public class ArrayMaxAreaValueAndIndex
    {
        public int MaxArea(int[] height)
        {
            int l = 0,
                r = height.Length - 1,
                current_max = 0,
                max = 0;
            while (l < r)
            {
                current_max = (r - l) * Math.Min(height[l], height[r]);
                if (current_max > max)
                    max = current_max;

                if (height[l] <= height[r])
                    l++;
                else
                    r--;
            }

            return max;
        }
    }
}
