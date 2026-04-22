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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //Find length of the list
        var curr = head;
        var length = 0;
        while (curr != null){
            length++;
            curr = curr.next;
        }

        //Go through the list
        var removeIndex = length - n;
        if (removeIndex == 0){
            return head.next;
        }

        curr = head;
        for (var i = 0 ; i < length - 1; i++){
            if(i + 1 == removeIndex){
                curr.next = curr.next.next;
                break;
            }
            curr = curr.next;

        }
        return head;
    }
}
