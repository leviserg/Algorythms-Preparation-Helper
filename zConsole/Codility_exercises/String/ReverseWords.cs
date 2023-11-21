using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.String
{
    public static class ReverseWords
    {
        public static string ReverseWordRecursive(string word)
        {
            return (word.Length == 1) ? word[0].ToString() : ReverseWordRecursive(word.Substring(1)) + word[0];
        }

        public static string ReverseWordsInSentence(string s)
        {
            s = s.Replace(" ",",").Trim();
            List<string> words = s.Split(',').ToList();
            StringBuilder sb = new StringBuilder();
            for(int i = words.Count - 1; i >= 0; i--)
            {
                if (words[i].Length != 0)
                {
                    sb.Append(words[i] + " ");
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
