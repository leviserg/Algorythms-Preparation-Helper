using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class DeepCopyOfLinkedListWithRandomPointers
    {
        public static NodeWRand CopyRandomList(NodeWRand head)
        {
            // HashMap usage (O(N) time; O(N) memory)
            /*
            if (head == null) return null;

            Dictionary<NodeWRand, NodeWRand> newNodesDict = new Dictionary<NodeWRand, NodeWRand>();

            NodeWRand curr = head;
            while (curr != null)
            {
                newNodesDict[curr] = new NodeWRand(curr.val);
                curr = curr.next;
            }

            curr = head;
            while (curr != null)
            {
                newNodesDict[curr].next = curr.next != null ? newNodesDict[curr.next] : null;
                newNodesDict[curr].random = curr.random != null ? newNodesDict[curr.random] : null;
                curr = curr.next;
            }

            return newNodesDict[head];
            */

            // Interweaving (Expand & Split) usage (O(N) time; O(1) memory)

            if (head == null) return null;

            NodeWRand curr = head;
            while (curr != null)
            {
                NodeWRand newNode = new NodeWRand(curr.val); // create new Nodes with copy of val & next props
                newNode.next = curr.next;
                curr.next = newNode; // expand original list by place new node btw curr & curr.next
                curr = newNode.next; // go to next original node
            }

            curr = head;
            while (curr != null)
            {
                if (curr.random != null)
                {
                    curr.next.random = curr.random.next; // copy random pointer from old node to the new ones (next in chain)
                }
                curr = curr.next.next; // traverse through the old nodes next.next (skip new ones - next)
            }

            // Split expanded list to select new nodes only

            NodeWRand oldHead = head;
            NodeWRand newHead = head.next; // new ones were placed after the old in expanded list
            NodeWRand currOld = oldHead; // item to iterate through the list using old ones
            NodeWRand currNew = newHead; // item to iterate through the list using new ones

            while (currOld != null)
            {
                currOld.next = currOld.next.next; // bring old nodes only
                currNew.next = (currNew.next != null) ? currNew.next.next : null; // bring new nodes only
                currOld = currOld.next; // set old nodes only
                currNew = currNew.next; // set new nodes only
            }

            return newHead; // return head of new linked list


        }

    }

    public class NodeWRand
    {
        public int val;
        public NodeWRand next;
        public NodeWRand random;

        public NodeWRand(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
