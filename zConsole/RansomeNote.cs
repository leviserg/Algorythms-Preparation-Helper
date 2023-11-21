using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole
{
    public static class RansomeNote
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> ransomMap = GetKeyValuePairs(ransomNote);
            Dictionary<char, int> magazineMap = GetKeyValuePairs(magazine);

            foreach(var key in ransomMap.Keys)
            {
                if (!magazineMap.ContainsKey(key))
                {
                    return false;
                }
                else
                {
                    if (magazineMap[key] < ransomMap[key])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static Dictionary<char, int> GetKeyValuePairs(string s)
        {
            if(s.Length== 0)
            {
                return null;
            }
            Dictionary<char, int> kvp = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!kvp.TryGetValue(s[i], out int val))
                {
                    kvp.Add(s[i], 1);
                }
                else
                {
                    kvp[s[i]]++;
                }
            }
            return kvp;
        }
    }
}
