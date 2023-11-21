using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.DictionaryHashTable
{
    public static class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int len = nums.Length;
            Array.Sort(nums);
            // <first number => to be changed with next number, length>
            for (int i = 0; i < len; i++)
            {
                int val = nums[i];
                if (!dict.ContainsKey(val))
                {
                    int prev = val - 1;
                    if (dict.ContainsKey(prev))
                    {
                        int cnt = dict[prev];
                        dict.Remove(prev);
                        dict[val] = cnt + 1;
                    }
                    else
                    {
                        dict[val] = 1;
                    }
                }
            }

            return dict.OrderByDescending(x => x.Value).FirstOrDefault().Value;

        }
    }
}
