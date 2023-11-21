using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.DictionaryHashTable
{
    public static class CheckDuplicatesInArray
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                int val = nums[i];
                if (dict.ContainsKey(val) && Math.Abs(dict[val] - i) <= k)
                {
                    return true;
                }
                dict[val] = i;
            }
            return false;
        }
    }
}
