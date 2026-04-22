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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode res = new ListNode();
        ListNode dummy = res;

        
        while (l1 != null || l2 != null || carry != 0){

            int val1 = (l1 != null) ? l1.val : 0;
            int val2 = (l2 != null) ? l2.val : 0;

            var sum = val1 + val2 + carry;

            carry = sum / 10;
            sum = sum % 10;

            dummy.next = new ListNode(sum);

            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
            dummy = dummy.next;
        }

        return res.next;

    }
}
