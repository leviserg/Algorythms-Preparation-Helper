using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.SlidingWindow
{
    public static class SlidingWindowPrimitives
    {
        /*
            Given an array of integers and a positive integer K,
            find the maximum sum of any contiguous subarray of size K.
        */
        public static int MaxSumSubarray(int[] arr, int k)
        {
            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];
                if (i >= k - 1)
                {
                    maxSum = Math.Max(maxSum, currentSum);
                    currentSum -= arr[i - k + 1];
                }
            }

            return maxSum;
        }

        /*
            Given an array of positive integers and a positive integer S,
            find the length of the smallest contiguous subarray with a sum greater than or equal to S.
        */
        public static int MinSubarrayLength(int[] arr, int s)
        {
            int minLength = int.MaxValue;
            int left = 0;
            int currentSum = 0;

            for (int right = 0; right < arr.Length; right++)
            {
                currentSum += arr[right];

                while (currentSum >= s)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    currentSum -= arr[left];
                    left++;
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }

        /*
            Given an array of integers,
            find the length of the longest subarray that contains at most two distinct elements.
         */
        public static int LengthOfLongestSubarray(int[] arr)
        {
            int maxLen = 0;
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            int left = 0;

            for (int right = 0; right < arr.Length; right++)
            {
                if (!frequencyMap.ContainsKey(arr[right]))
                    frequencyMap[arr[right]] = 0;
                frequencyMap[arr[right]]++;

                while (frequencyMap.Count > 2)
                {
                    frequencyMap[arr[left]]--;
                    if (frequencyMap[arr[left]] == 0)
                        frequencyMap.Remove(arr[left]);
                    left++;
                }

                maxLen = Math.Max(maxLen, right - left + 1);
            }

            return maxLen;
        }
    }
}
