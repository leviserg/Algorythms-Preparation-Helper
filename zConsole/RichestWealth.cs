using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole
{
    public static class RichestWealth
    {
        public static int MaximumWealth(int[][] accounts)
        {
            int result = 0;
            int sum = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sum += accounts[i][j];
                }
                result = (sum > result) ? sum : result;
                sum = 0;
            }
            return result;
        }

        public static int ShortMaximumWealth(int[][] accounts)
        {
            int result = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = accounts[i].Sum();
                result = Math.Max(sum, result);
            }
            return result;
        }
        
        public static int MaximumWealthLinq(int[][] accounts)
        {
            return accounts.Select(ac => ac.Sum()).Max();
        }
    }
}
