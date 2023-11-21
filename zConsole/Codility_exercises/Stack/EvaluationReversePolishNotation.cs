using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.Stack
{
    public static class EvaluationReversePolishNotation
    {
        public static int EvalRPN(string[] tokens)
        {
            //["2","1","+","3","*"]
            //((2 + 1) * 3) = 9

            Stack<int> stack = new Stack<int>();
            int result = 0;
            int i = 0;
            while (i < tokens.Length)
            {
                if (int.TryParse(tokens[i], out int num))
                {
                    stack.Push(num);
                }
                else
                {
                    int n2 = stack.Pop();
                    int n1 = stack.Pop();
                    stack.Push(Calculate(n1, n2, tokens[i].First()));
                }
                i++;
            }
            result = stack.Pop();
            return result;
        }

        private static int Calculate(int n1, int n2, char sign)
        {
            if (sign == '+')
            {
                return n1 + n2;
            }
            else if (sign == '-')
            {
                return n1 - n2;
            }
            else if (sign == '*')
            {
                return n1 * n2;
            }
            else if (sign == '/')
            {
                return n1 / n2;
            }
            return n1;
        }
    }
}
