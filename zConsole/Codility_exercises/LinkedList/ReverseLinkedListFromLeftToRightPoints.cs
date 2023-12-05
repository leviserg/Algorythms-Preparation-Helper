using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class ReverseLinkedListFromLeftToRightPoints
    {
        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {

            ListNode curr = head;
            int step = 0;
            Stack<int> stack = new Stack<int>();
            while (curr != null && step < right)
            {
                if (step >= left - 1)
                {
                    stack.Push(curr.val);
                }
                step++;
                curr = curr.next;
            }
            step = 0;
            curr = head;
            while (curr != null && step < right)
            {
                if (step >= left - 1)
                {
                    curr.val = stack.Pop();
                }
                step++;
                curr = curr.next;
            }

            return head;

        }
    }
}
