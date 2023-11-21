using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises
{
    public class StringAppendConsecLettersNotMoreThanThree
    {

        public int GetSymCharOfString(string S)
        {
            if (string.IsNullOrEmpty(S) || S.Length % 2 == 0)
            {
                return -1;
            }
            int left = 0;
            int right = S.Length - 1;
            while (left < right)
            {
                if (S[left] == S[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return -1;
                }
            }
            return (right == left) ? left : -1;
        }



        public string GetConsecutiveString(int A, int B)
        {
            StringBuilder result = new StringBuilder();

            char charA = 'a';
            char charB = 'b';

            if (A < B)
            {
                // Swap 'a' and 'b' if B is greater than A
                charA = 'b';
                charB = 'a';
                int temp = A;
                A = B;
                B = temp;
            }

            while (A > 0 || B > 0)
            {
                if (A > 0)
                {
                    result.Append(charA);
                    A--;
                }

                if (A > B)
                {
                    result.Append(charA);
                    A--;
                }

                if (B > 0)
                {
                    result.Append(charB);
                    B--;
                }
            }

            return result.ToString();
        }
    }
}
