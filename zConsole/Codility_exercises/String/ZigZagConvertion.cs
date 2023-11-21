using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.String
{
    public static class ZigZagConvertion
    {

        /*
            PAYPALISHIRING -> PAHNAPLSIIGYIR   
            P   A   H   N
            A P L S I I G
            Y   I   R
         */

        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            var output = new StringBuilder(s.Length);

            var period = numRows * 2 - 2;

            for (int row = 0; row < numRows; ++row)
            {
                var increment = 2 * row;
                for (int i = row; i < s.Length; i += increment)
                {
                    output.Append(s[i]);
                    if (increment != period)
                    {
                        increment = period - increment;
                    }
                }
            }
            return output.ToString();
        }
    }
}
