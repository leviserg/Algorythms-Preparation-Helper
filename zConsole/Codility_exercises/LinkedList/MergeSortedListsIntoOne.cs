using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class MergeSortedListsIntoOne
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummyNode = new ListNode(-1);
            ListNode current = dummyNode;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            current.next = (list1 != null) ? list1 : list2;
            return dummyNode.next; // skip dummyNode
        }
    }
}
