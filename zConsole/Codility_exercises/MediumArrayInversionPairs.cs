using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises
{
    public class MediumArrayInversionPairs
    {

        public int CountInversions(int[] A)
        {
            int[] temp = new int[A.Length];
            return MergeSortAndCountInversions(A, temp, 0, A.Length - 1);
        }

        private int MergeSortAndCountInversions(int[] A, int[] temp, int left, int right)
        {
            if (left >= right)
            {
                return 0;
            }

            int mid = (left + right) / 2;
            int inversions = 0;

            inversions += MergeSortAndCountInversions(A, temp, left, mid);
            inversions += MergeSortAndCountInversions(A, temp, mid + 1, right);

            inversions += MergeAndCountSplitInversions(A, temp, left, mid, right);

            return (inversions > 1000000000) ? -1 : inversions;
        }

        private int MergeAndCountSplitInversions(int[] A, int[] temp, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int inversions = 0;

            while (i <= mid && j <= right)
            {
                if (A[i] <= A[j])
                {
                    temp[k++] = A[i++];
                }
                else
                {
                    // A[j] is smaller than A[i], so it forms inversions with the remaining elements in the left subarray
                    temp[k++] = A[j++];
                    inversions += mid - i + 1;

                    if (inversions > 1_000_000_000)
                    {
                        return -1; // Exceeds the limit
                    }
                }
            }

            while (i <= mid)
            {
                temp[k++] = A[i++];
            }

            while (j <= right)
            {
                temp[k++] = A[j++];
            }

            // Copy the merged result back to the original array
            for (int l = left; l <= right; l++)
            {
                A[l] = temp[l];
            }

            return inversions;
        }
    }
}
