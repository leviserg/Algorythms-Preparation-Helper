using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole
{
    public static class FizzBuzzClass
    {
        public static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(getElem(i));
            }
            GC.Collect();
            return list;
            //return new List<string> { "1", "2", "Fizz", "4", "Buzz"};
        }

        private static string getElem (int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
                return "FizzBuzz";
            else if (n % 3 == 0)
                return "Fizz";
            else if (n % 5 == 0)
                return "Buzz";
            else return n.ToString();
        }
    }
}
