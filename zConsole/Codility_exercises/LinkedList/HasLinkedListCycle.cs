using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class HasLinkedListCycle
    {
        public static bool HasCycle(ListNode head)
        {
            if (head is null)
            {
                return false;
            }
            ListNode curNode = head;
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (curNode != null)
            {
                if (set.Contains(curNode))
                {
                    return true;
                }
                set.Add(curNode);
                curNode = curNode.next;
            }
            return false;
        }
    }
}
