using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.String
{
    public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] ss)
        {
            int i = 0;
            StringBuilder sb = new();
            string shortest = ss.OrderBy(s => s.Length).First();

            foreach (char c in shortest)
            {
                if (ss.Any(s => s[i] != c)) break;
                sb.Append(c);
                i++;
            }

            return sb.ToString();
        }
    }
}
