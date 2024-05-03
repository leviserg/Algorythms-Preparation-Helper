using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class LinkeListIsPalindrome
    {
        public static bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            if (head.next == null)
                return true;

            ListNode cur = head;
            while (cur != null)
            {
                stack.Push(cur.val);
                cur = cur.next;
            }
            cur = head;
            int i = 1;
            while (i < stack.Count())
            {
                Console.WriteLine("cycle : " + cur.val.ToString() + " : " + stack.Peek());
                if (cur.val == stack.Pop())
                {
                    if (cur.next == null)
                    {
                        return true;
                    }
                    cur = cur.next;
                }
                else
                {
                    return false;
                }
                i++;
            }

            Console.WriteLine("final : " + cur.val.ToString() + " : " + stack.Peek());
            return cur.val == stack.Pop();//true;
        }
    }
}
