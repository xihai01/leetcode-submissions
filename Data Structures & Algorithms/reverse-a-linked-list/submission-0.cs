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

public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) return head;
        // keep track of curr and next node
        ListNode l = head;
        ListNode r = l.next;
        while (r != null) {
            ListNode temp = r.next;  // keep track of list when we switch pointers
            r.next = l;
            l = r;
            r = temp;
        }
        head.next = null;
        head = l;
        return head;
    }
}
