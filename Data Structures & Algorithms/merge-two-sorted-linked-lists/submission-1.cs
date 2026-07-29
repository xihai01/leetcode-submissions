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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode res = new ListNode();
        ListNode dummy = res;
        while(list1 != null && list2 != null) {
            if (list2.val <= list1.val) {
                dummy.next = list2;
                list2 = list2.next;
            }
            else {
                dummy.next = list1;
                Console.WriteLine(list1.val);
                Console.WriteLine(list2.val);
                list1 = list1.next;
            }
            dummy = dummy.next;
        }
        // reattach the remaining nodes of which ever list is left
        if (list1 != null) dummy.next = list1;
        if (list2 != null) dummy.next = list2;
        return res.next;
    }
}