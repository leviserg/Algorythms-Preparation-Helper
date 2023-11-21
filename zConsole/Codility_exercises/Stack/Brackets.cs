using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Stack
{
    public static class Brackets
    {
        public static bool IsBalancedBrackets(string S)
        {
            Stack<char> stack = new Stack<char>();
            if (string.IsNullOrEmpty(S))
            {
                return true;
            }
            for (int i = 0; i < S.Length; i++)
            {
                char ch = S[i];
                if (ch == '{' || ch == '(' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else if (ch == '}')
                {
                    if (stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else { return false; }

                }
                else if (ch == ']')
                {
                    if (stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else { return false; }

                }
                else if (ch == ')')
                {
                    if (stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else { return false; }

                }
            }
            return stack.Count == 0;
        }
    }
}
