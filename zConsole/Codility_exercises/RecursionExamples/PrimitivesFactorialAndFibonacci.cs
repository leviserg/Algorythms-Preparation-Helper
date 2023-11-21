using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.RecursionExamples
{
    public static class PrimitivesFactorialAndFibonacci
    {
        public static int GetFactorial(int n) {
            if (n == 0) return 1;
            return n * GetFactorial(n-1);
        }

        public static IEnumerable<int> GetFibonacci(int n)
        {
            List<int> fibonacci = new List<int>();
            for(int i = 0; i < n; i++)
            {
                fibonacci.Add(GetFibonacciNumber(i));
            }
            return fibonacci.AsEnumerable();
        }

        private static int GetFibonacciNumber(int step)
        {
            if (step == 0) return 0;
            else if(step == 1) return 1;
            return GetFibonacciNumber(step - 1) + GetFibonacciNumber(step - 2);
        }
    }
}
