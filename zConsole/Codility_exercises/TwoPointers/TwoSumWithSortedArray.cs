using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.TwoPointers
{
    public class TwoSumWithSortedArray
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target) break;
                if (sum < target) left++;
                if (sum > target) right--;
            }
            return new int[] { left + 1, right + 1 };
        }
    }
}
