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

/*
EX: 1
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

EX: 2
Input: l1 = [0], l2 = [0]
Output: [0]

EX: 3
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
*/

using LeetCode2;
using System.Collections.Generic;

/*
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
*/

//int[] arr1 = new int[3] { 2, 4, 3 };
//int[] arr2 = new int[3] { 5, 6, 4 };

//int[] arr1 = new int[1] { 9 };
//int[] arr2 = new int[10] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 };

int[] arr1 = new int[31] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
int[] arr2 = new int[3] { 5, 6, 4 };

ListNode l1 = new ListNode(arr1[0]);
ListNode current = l1;

for (int i = 1; i < arr1.Length; i++)
{
    current.next = new ListNode(arr1[i]);
    current = current.next;
}

ListNode l2 = new ListNode(arr2[0]);
ListNode current2 = l2;

for (int j = 1; j < arr2.Length; j++)
{
    current2.next = new ListNode(arr2[j]);
    current2 = current2.next;
}

//ListNode l3 = new ListNode(3, null);
//ListNode l2 = new ListNode(4, l3);
//ListNode l1 = new ListNode(2, l2);

//ListNode l6 = new ListNode(4, null);
//ListNode l5 = new ListNode(6, l6);
//ListNode l4 = new ListNode(5, l5);

Solution solution = new Solution();
ListNode result = solution.AddTwoNumbers(l1, l2);
//ListNode result = solution.AddTwoNumbers(l1, l2, 0);

while (l1 != null)
{
    Console.WriteLine(l1.val);
    l1 = l1.next;
}

while (l2 != null)
{
    Console.WriteLine(l2.val);
    l2 = l2.next;
}

while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}

Console.ReadKey();