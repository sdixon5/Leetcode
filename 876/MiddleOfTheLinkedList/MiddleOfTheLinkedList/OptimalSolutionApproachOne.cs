using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOfTheLinkedList
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class OptimalSolutionApproachOne
    {
        public ListNode MiddleNode(ListNode head)
        {
            // Use List<T> instead of ArrayList for type safety and to fix CS0308
            List<ListNode> array = new List<ListNode>();

            int length = 0;

            while (head != null)
            {
                array.Add(head);
                head = head.next;
                length++;
            }

            // Access the middle element using the index
            return array[length / 2];
        }
    }
}
