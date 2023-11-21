using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.String
{
    public static class IsoMorphicString
    {
        public static bool IsIsomorphic(string s, string t)
        {

            HashSet<char> s_set = new HashSet<char>(s);
            HashSet<char> t_set = new HashSet<char>(t);
            var zipped = t.Zip(s, (c1, c2) => $"{c1}{c2}");
            HashSet<string> st_set = new HashSet<string>(zipped);
            return (s_set.Count == t_set.Count) && (s_set.Count == st_set.Count);

            /*
                var dict = new Dictionary<char, char>();
                for(int i = 0 ; i < s.Length; i++)
                {
                    char ss = s[i];
                    char st = t[i];
                    if(dict.ContainsKey(ss))
                    {
                        if(st != dict[ss]) return false;
                    } else 
                    {
                        if(dict.ContainsValue(st)) return false;
                        dict.Add(ss, st);
                    }
                }
                return true;
             */
        }

        public static bool WordPattern(string pattern, string s)
        {
            Dictionary<string, char> dict = new Dictionary<string, char>();
            List<string> words = s.Split(' ').ToList();
            int patternLength = pattern.Length;
            int distinctWordLength = words.Distinct().ToList().Count;
            int distinctPatternLength = pattern.Distinct().ToList().Count;

            //HashSet<char>
            int i = 0;

            foreach (string word in words)
            {
                if (i < patternLength && dict.ContainsKey(word))
                {
                    if (dict[word] != pattern[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (i < patternLength)
                    {
                        dict.Add(word, pattern[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
                i++;
            }

            return distinctWordLength == distinctPatternLength;

        }

        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    dict[c]--;
                }
            }
            return dict.All(x => x.Value == 0);
        }

        public static int GetSquares(int n)
        {
            List<int> digits = new List<int>();
            while (n > 0)
            {
                int digit = n % 10;
                digits.Add(digit);
                n /= 10;
            }
            return digits.Sum(x => x * x);
        }
    }
}
