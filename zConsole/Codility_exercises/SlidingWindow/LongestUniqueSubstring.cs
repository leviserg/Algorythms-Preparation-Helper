using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.SlidingWindow
{
    public class LongestUniqueSubstring
    {
        private const int NO_OF_CHARS = 256;


        public int GetUniqueSubString_(string S)
        {
            var charSet = new HashSet<char>();
            int left = 0, right = 0, maxLength = 0;
            while (right < S.Length)
            {
                if (!charSet.Contains(S[right]))
                {
                    charSet.Add(S[right]);
                    right++;
                    maxLength = Math.Max(maxLength, charSet.Count);
                }
                else
                {
                    charSet.Remove(S[left]);
                    left++;
                }
            }
            return maxLength;
        }





        public int GetUniqueSubstring(string S)
        {

            int res = 0; // result
            // last index of all characters is initialized
            // as -1
            int[] lastIndex = new int[NO_OF_CHARS];
            Array.Fill(lastIndex, -1);

            // Initialize start of current window

            int i = 0;

            // Move end of current window

            for (int j = 0; j < S.Length; j++)
            {
                // Find the last index of str[j]
                // Update i (starting index of current window)
                // as maximum of current value of i and last
                // index plus 1
                i = Math.Max(i, lastIndex[S[j]] + 1);
                // Update result if we get a larger window
                res = Math.Max(res, j - i + 1);
                // Update last index of j.
                lastIndex[S[j]] = j;
            }
            return res;
        }
    }
}
