using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.ArrayMergeSortClassic
{
    public class Sorter
    {


        public int[] MergeSort(int[] arr)
        {
            int length = arr.Length;

            // Base case: If the array has one or zero elements, it's already sorted
            if (length <= 1)
                return arr;

            // Split the array into two halves
            int mid = length / 2;

            int[] left = arr.Skip(0).Take(mid).ToArray();
            int[] right = arr.Skip(mid).Take(length).ToArray();

            // Recursively sort each half
            left = MergeSort(left);
            right = MergeSort(right);

            // Merge the sorted halves and return the result
            return Merge(left, right);

        }

        private int[] Merge(int[] left, int[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int[] result = new int[leftLength + rightLength];
            int i = 0, j = 0, k = 0;

            // Compare elements from the left and right arrays and merge them into the result array
            while (i < leftLength && j < rightLength)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy any remaining elements from the left and right arrays
            while (i < leftLength)
            {
                result[k] = left[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                result[k] = right[j];
                j++;
                k++;
            }

            return result;
        }
    }
}
