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
    public class Solution
    {
        List<int> ints = new List<int>();

        public ListNode MiddleNode(ListNode head)
        {
            GetInts(head);

            if (ints.Count != 0)
            {
                return BuildNewHead(ints);
            }

            return null;
        }

        private void GetInts(ListNode head)
        {
            //ints.Add(head.val);

            while (head.next != null)
            {
                ints.Add(head.val);
                head = head.next;
            }

            ints.Add(head.val); //to account for last head where next is null
        }

        private ListNode BuildNewHead(List<int> ints)
        {
            int total = ints.Count();

            var index = total / 2;

            List<int> values = new List<int>();

            for (int i = index; i < ints.Count(); i++)
            {
                values.Add(ints[i]);
            }

            var head = BuildList(values.ToArray());

            return head;
        }

        private static ListNode BuildList(int[] values)
        {
            if (values == null || values.Length == 0) return null;
            var head = new ListNode(values[0]);
            var current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
            return head;
        }
    }
}
