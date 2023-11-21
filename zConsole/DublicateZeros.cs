using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole
{
    public static class DublicateZeros
    {
        public static void Run(int[] arr)
        {
            int zeroCount = arr.Where(x => x == 0).Count();

            var position = arr.Length - 1; // start from the end

            while (position > 0 && zeroCount > 0) // will run through all array items or while all zeros elements will processed
            {
                if (position + zeroCount <= arr.Length - 1) // operate inside of array
                {
                    arr[position + zeroCount] = arr[position]; // move non-zero element from cur position to the destination (cur + zeroCnt) before it will be replaced with zero on line 30
                }

                if (arr[position] == 0)
                {
                    zeroCount--;  // decr zeroCount when face zero for the position
                }

                arr[position] = 0; // this will set zeroCount array elements from right to zero, cause they will be moved anyway and insert dublicate zeros

                position--; // decr position while inside array or zeroCount>0

            }
        }


        private static string ArrayToString(int[] nums)
        {
            StringBuilder sb = new StringBuilder("[");
            for (int i = 0; i < nums.Length; i++)
            {
                sb.Append($"{nums[i].ToString()},");
            }
            sb.Replace(",", "]", sb.Length - 1, 1);
            return sb.ToString();
        }
    }

}



