using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole
{
    public static class TwoSum
    {
        public static int[] GetTwoSum(int[] nums, int target)
        {

            
            Dictionary<int, int> diffs = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length;i++)
            {
                int diff = target - nums[i];
                if (diffs.ContainsKey(diff))
                {
                    return new int[] { i, diffs[diff] };
                }
                if(!diffs.TryAdd(nums[i], i)){
                    diffs[nums[i]] = i;
                }
            }

            return null;
        }
    }
}
