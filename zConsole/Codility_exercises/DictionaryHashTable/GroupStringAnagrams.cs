using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.DictionaryHashTable
{
    public static class GroupStringAnagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return new string[1][];

            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string sortedStr = new string(charArray); // get unique key for available anagrams
                if (anagramGroups.ContainsKey(sortedStr))
                {
                    anagramGroups[sortedStr].Add(str);
                }
                else
                {
                    anagramGroups[sortedStr] = new List<string> { str };
                }
            }

            string[][] jaggedArray = new string[anagramGroups.Count][];

            int rowIndex = 0;
            foreach (var keyValuePair in anagramGroups)
            {
                jaggedArray[rowIndex] = keyValuePair.Value.ToArray();
                rowIndex++;
            }
            return jaggedArray;
        }
    }
}
