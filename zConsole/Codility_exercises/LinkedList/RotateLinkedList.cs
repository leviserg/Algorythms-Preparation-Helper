using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class RotateLinkedList
    {
        public static ListNode RotateRight(ListNode head, int k)
        {

            if (head == null)
            {
                return null;
            }

            var length = 1;
            var tail = head;

            while (tail.next != null)
            {
                length++;
                tail = tail.next;
            }

            tail.next = head; // append list to the end of the list 1->2->3-4 => 1->2->3->4->(1->2->3->4)

            k = length - k % length; // get number of steps for rotation

            for (var i = 0; i < k; i++)
            {
                head = head.next; // move from the start (1->2)->3->4->...
                tail = tail.next; // move from the last position (end of primary list) ->4->1->2->(3->...
            }

            tail.next = null; // cut the rest of list for k steps from the end position 4->1->2(->3->4)

            return head;
        }
    }
}
