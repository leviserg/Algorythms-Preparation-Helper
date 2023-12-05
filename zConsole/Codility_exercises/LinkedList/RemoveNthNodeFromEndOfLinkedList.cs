using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class RemoveNthNodeFromEndOfLinkedList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new(0, head);
            ListNode second = dummy;
            ListNode first = dummy;
            // 1-2-3-4-5 (4 to be removed)
            // Gap of first and second is n - move first to n step ahead of second
            for (int i = 0; i < n; i++)
            {
                first = first.next; // 1-2
            }

            // Move both pointers till first gets to the end
            while (first?.next != null)
            {
                second = second.next; //1-2-3
                first = first.next; //3-4-5
            }

            // Delete the node next to the second (using link to next.next instead of next)
            second.next = second.next.next; // 1-2-3->5 (4 removed)

            return dummy.next;
        }
    }
}
