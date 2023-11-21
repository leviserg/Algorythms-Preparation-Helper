using System.Collections.Generic;
using System.Linq;

namespace zConsole
{
    public static class LinkedListOneDirOps
    {
        public static LinkedList<int> ToLinkedList(int[] array)
        {
            return new LinkedList<int>(array);
        }

        public static ListNode ToCustomLinkedList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null; // Return null if the list is empty
            }

            ListNode customList = new ListNode(array[0]);
            ListNode currentCustomNode = customList;

            for (int i = 1; i < array.Length; i++)
            {
                ListNode newNode = new ListNode(array[i]);
                currentCustomNode.next = newNode;
                currentCustomNode = newNode;
            }

            return customList;
        }

        public static int GetSum(LinkedListNode<int> head)
        {
            if (head.Next == null)
            {
                return head.Value;
            }
            return head.Value + GetSum(head.Next);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            /*
            if (l1 == null && l2 == null && carry == 0) return null;

            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;
            return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
            */

            
            LinkedList<int> ret = new LinkedList<int>();
            int nextOrder = 0;
            while (l1 != null || l2 != null || nextOrder != 0)
            {
                int l1Value = (l1 is null) ? 0 : l1.val;
                int l2Value = (l2 is null) ? 0 : l2.val;

                int value = l1Value + l2Value + nextOrder;

                ret.AddLast(value % 10);
                nextOrder = (value >= 10) ? 1 : 0;
                
                l1 = l1?.next;
                l2 = l2?.next;
            }
            return ConvertToCustomListNode(ret);
            
        }

        public static ListNode ConvertToCustomListNode(LinkedList<int> linkedList)
        {
            if (linkedList == null || linkedList.Count == 0 || linkedList.First == null)
            {
                return null; // Return null if the list is empty
            }

            var firstNode = linkedList.First;
            var customList = new ListNode(firstNode.Value);
            var currentCustomNode = customList;
            var currentNode = firstNode.Next;

            while (currentNode != null)
            {
                var newNode = new ListNode(currentNode.Value);
                currentCustomNode.next = newNode;
                currentCustomNode = newNode;
                currentNode = currentNode.Next;
            }

            return customList;
        }

        public static int[] ConvertCustomListNodeToArray(ListNode listNode)
        {
            List<int> ret = new List<int>();

            while (listNode != null)
            {
                ret.Add(listNode.val);
                listNode = listNode.next;
            }

            return ret.ToArray();
        }
    }



    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
