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
    public void ReorderList(ListNode head) {
        ListNode l1 = head;
        ListNode l2 = head.next;
        while (l2 != null && l2.next != null) {
            l1 = l1.next;
            l2 = l2.next.next;
        }

        //Reverse the 2nd half
        ListNode second = l1.next;
        ListNode prev = l1.next = null;
        while (second != null){
            var temp = second.next;
            second.next = prev;
            prev = second;
            second = temp;
        }

        //Link the 2 lists back together
        ListNode first = head;
        second = prev;
        while (second != null){
            var temp1 = first.next;
            var temp2 = second.next;
            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }

        
    }
}
