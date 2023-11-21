using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.String
{
    public static class IntToRoman
    {
        public static string ToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<int, char> dic = new Dictionary<int, char> {
                {1,   'I'},
                {5,   'V'},
                {10,  'X'},
                {50,  'L'},
                {100, 'C'},
                {500, 'D'},
                {1000,'M'}
            };

            if (dic.ContainsKey(num))
            {
                sb.Append(dic[num]);
            }
            else
            {
                List<int> orders = new List<int>();
                while (num > 0)
                {
                    orders.Add(num % 10);
                    num = num / 10;
                }
                if (orders.Count > 3 && orders[3] > 0)
                {
                    sb.Append(BuildRomanForOrder(dic, orders[3], 1000));
                }
                if (orders.Count > 2 && orders[2] > 0)
                {
                    sb.Append(BuildRomanForOrder(dic, orders[2], 100));
                }

                if (orders.Count > 1 && orders[1] > 0)
                {
                    sb.Append(BuildRomanForOrder(dic, orders[1], 10));
                }


                if (orders.Count > 0 && orders[0] > 0)
                {
                    sb.Append(BuildRomanForOrder(dic, orders[0], 1));
                }

            }

            return sb.ToString();

            /*
            var map = new Dictionary<int, string>{
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90,  "XC"},
                {50,  "L"},
                {40,  "XL"},
                {10,  "X"},
                {9,   "IX"},
                {5,   "V"},
                {4,   "IV"},
                {1,   "I"}
            };

            var sb = new StringBuilder();

            foreach (var pair in map)
            {
                int digit = num / pair.Key;

                while (digit-- > 0)
                {
                    sb.Append(map[pair.Key]);
                }

                num = num % pair.Key;
            }

            return sb.ToString();
            */
        }

        private static string BuildRomanForOrder(Dictionary<int, char> dic, int unit, int multiplyer)
        {
            StringBuilder sb = new StringBuilder();
            int value = unit * multiplyer;
            if (dic.ContainsKey(value))
            {
                sb.Append(dic[value]);
            }
            else if (dic.ContainsKey(value + 1 * multiplyer)) // 4,9 
            {
                sb.Append(dic[multiplyer]); // IV, IX
                sb.Append(dic[value + 1 * multiplyer]);
            }
            else if (dic.ContainsKey(value - 1 * multiplyer)) // 2,6 
            {
                sb.Append(dic[value - 1 * multiplyer]); // VI, II
                sb.Append(dic[multiplyer]);
            }
            else if (dic.ContainsKey(value - 2 * multiplyer)) // 7,3
            {
                sb.Append(dic[value - 2 * multiplyer]);
                sb.Append(dic[multiplyer]);
                sb.Append(dic[multiplyer]);
            }
            else if (dic.ContainsKey(value - 3 * multiplyer) && dic.ContainsKey(value + 2 * multiplyer)) // 8
            {
                sb.Append(dic[value - 3 * multiplyer]);
                sb.Append(dic[multiplyer]);
                sb.Append(dic[multiplyer]);
                sb.Append(dic[multiplyer]);
            }
            return sb.ToString();
        }
    }
}
