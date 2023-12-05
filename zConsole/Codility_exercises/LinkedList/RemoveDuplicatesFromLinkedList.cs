using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class RemoveDuplicatesFromLinkedList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            ListNode curr = head;

            while (curr != null)
            {
                if (!dict.TryGetValue(curr.val, out int val))
                {
                    dict.Add(curr.val, 1);
                }
                else
                {
                    dict[curr.val]++;
                }
                curr = curr.next;
            }

            ListNode dummy = new ListNode();
            curr = dummy;
            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    curr.next = new ListNode(item.Key);
                    curr = curr.next;
                }
            }

            return dummy.next;
        }
    }
}
