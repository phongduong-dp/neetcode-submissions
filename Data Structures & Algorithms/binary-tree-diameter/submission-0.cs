/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {

    private int res = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        return res;
    }

    // return height
    private int DFS(TreeNode curr){
        if (curr == null) return 0;

        var left = DFS(curr.left);
        var right = DFS(curr.right);

        res = Math.Max(res, left + right);

        return Math.Max(left, right) + 1;

    }
}
