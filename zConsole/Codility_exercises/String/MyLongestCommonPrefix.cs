using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.String
{
    public static class MyLongestCommonPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            StringBuilder sb = new StringBuilder();
            var smallestString = strs.OrderBy(s => s.Length).FirstOrDefault();
            if (string.IsNullOrEmpty(smallestString))
            {
                return sb.ToString();
            }
            for(int i = 0; i < smallestString.Length; i++)
            {
                char ch = smallestString[i];
                int j = 0;
                bool isPartOfCommonPrefix = true;
                while(j < strs.Length)
                {
                    isPartOfCommonPrefix = (isPartOfCommonPrefix && strs[j][i] == ch);
                    j++;
                }

                if (isPartOfCommonPrefix)
                {
                    sb.Append(ch);
                }
                else
                {
                    return sb.ToString();
                }

                /*
                for(int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] == smallestString[i])
                    {
                        sb.Append(smallestString[j]);
                    }
                    else
                    {
                        return sb.ToString();
                    }
                }
                */
            }

            return sb.ToString();
        }




        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            foreach(char ch in s)
            {
                if(ch == '(') { 
                    stack.Push(ch);
                }
                else if(ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == '[')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.TryPeek(out char vch))
                    {
                        if ((ch == ']' && vch == '[') || (ch == ')' && vch == '(') || (ch == '}' && vch == '{'))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

    }
}
