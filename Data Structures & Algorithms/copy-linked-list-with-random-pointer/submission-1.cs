/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary <Node, Node> oldToCopy = new Dictionary<Node, Node>();

        var curr = head;
        while (curr != null){
            Node copy = new Node(curr.val);
            oldToCopy[curr] = copy;
            curr = curr.next;
        }

        curr = head;
        while (curr != null){
            oldToCopy[curr].next = curr.next != null ? oldToCopy[curr.next] : null;
            oldToCopy[curr].random = curr.random != null ? oldToCopy[curr.random] : null;
            curr = curr.next;
        }

        return head != null ? oldToCopy[head] : null;

    }
}
