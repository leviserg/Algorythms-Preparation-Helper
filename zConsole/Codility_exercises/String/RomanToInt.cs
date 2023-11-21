using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.String
{
    public static class RomanToInt
    {
        public static int ConvertRomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>{
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            char[] ch = s.ToCharArray();

            int result = 0;
            int lastIdx = ch.Length - 1;

            for (int i = 0; i < ch.Length; i++)
            {
                int intVal = dict[ch[i]];

                if (i != lastIdx)
                {
                    int nextIntVal = dict[ch[i + 1]];

                    if (nextIntVal > intVal)
                    {
                        intVal = nextIntVal - intVal;
                        i++;
                    }
                }

                result += intVal;
            }
            return result;
        }
    }
}
