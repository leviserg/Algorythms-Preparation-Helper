using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zConsole.Codility_exercises.LinkedList
{
    public static class PartitionLinkedList
    {
        public static ListNode Partition(ListNode head, int x)
        {

            ListNode lessThanXVals = new ListNode(0);
            ListNode moreThanXVals = new ListNode(0);
            ListNode lessThanXVals_curr = lessThanXVals;
            ListNode moreThanXVals_curr = moreThanXVals;

            while (head != null)
            {
                if (head.val < x)
                {
                    lessThanXVals_curr.next = head; // set node value for linked list with lower values (less than x)
                    lessThanXVals_curr = lessThanXVals_curr.next; // move cursor through the list with lower values to the next node
                }
                else
                {
                    moreThanXVals_curr.next = head; // set node value for linked list with higher (or eq) values (more than x)
                    moreThanXVals_curr = moreThanXVals_curr.next; // move cursor through the list with higher (or eq) values to the next node
                }
                head = head.next; // iterate through the primary list
            }

            moreThanXVals_curr.next = null; // сut the list of bigger values at the current position
            lessThanXVals_curr.next = moreThanXVals.next; // append head of bigger values list to the end of the list with lower values

            return lessThanXVals.next; // return whole list starts from skipped dummy node (line 1) with lower values + appended list of bigger vals
        }
    }
}
