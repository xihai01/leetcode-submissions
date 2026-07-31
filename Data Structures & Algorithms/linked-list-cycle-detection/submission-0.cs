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
        var map = new Dictionary<ListNode, int>();
        ListNode curr = head;
        int i = 0;
        while(curr != null) {
            // check our map to make sure we are not revisiting an old node
            if (map.ContainsKey(curr)) {
                return true;
            } else {
                map.Add(curr, i);
            }
            curr = curr.next;
            i++;
        }
        return false;
    }
}
