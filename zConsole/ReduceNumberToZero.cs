using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole
{
    public static class ReduceNumberToZero
    {
        public static int NumberOfSteps(int num)
        {
            // Recursive
            /*
            if (num == 0) return 0;
            else if (num % 2 == 0)
                return 1 + NumberOfSteps(num / 2);
            return 1 + NumberOfSteps(num - 1);
            */
            // Biwise
            int count = 0;
            while (num != 0)
            {
                //int check = num & 1; // check for least bit (odd == 1 / even == 0)

                num = ((num & 1) == 0) ? num >> 1 : num - 1;
                /*
                if (check == 0)
                {
                    num = num >> 1; // if even shift number as set of bit to least side -> 10110 => 1011 - divide / 2 
                }
                else
                {
                    num = num - 1; //
                }
                */
                count++;
            }
            return count;



            // Beginner
            /*
             * int step = 0;
            while (num != 0)
            {
                if(num % 2== 0)
                {
                    num = num/ 2;
                }
                else { num--; }
                step++;
            }
            return step;
            */
        }
    }
}
