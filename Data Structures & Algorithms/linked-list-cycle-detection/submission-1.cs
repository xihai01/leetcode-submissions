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
    public bool HasCycle(ListNode head) {
        var map = new HashSet<ListNode>();
        while(head != null) {
            // check our map to make sure we are not revisiting an old node
            if (!map.Add(head)) return true;
            head = head.next;
        }
        return false;
    }
}
