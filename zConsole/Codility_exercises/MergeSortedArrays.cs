using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises
{
    public class MergeSortedArrays
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // nums1 = [1,2,3,0,0] (m = 3; m+n = 5)
            // nums2 = [3,4] (n = 2)
            int p1 = m - 1; // m - length of nums1 (m + n - covered with zeros)
            int p2 = n - 1; // n - length of nums2
            int i = m + n - 1;

            while (p2 >= 0)
            {
                if (p1 >= 0 && nums1[p1] > nums2[p2])
                    nums1[i--] = nums1[p1--];
                else
                    nums1[i--] = nums2[p2--];
            }
        }
    }
}
