using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.SlidingWindow
{
    public class MinSubArraySumGETarget
    {
        public int MinSubArrayLen(int target, int[] nums)
        {

            int result = int.MaxValue, runningSum = 0, left = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                runningSum += nums[i];
                while (runningSum >= target)
                {
                    result = Math.Min(result, i + 1 - left);
                    runningSum -= nums[left];
                    left++;
                }
            }
            return result == int.MaxValue ? 0 : result;

        }
    }
}
