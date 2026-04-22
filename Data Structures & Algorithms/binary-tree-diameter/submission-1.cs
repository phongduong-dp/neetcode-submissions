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

    public int DiameterOfBinaryTree(TreeNode root) {
        int res = 0;
        DFS(root, ref res);
        return res;
    }

    // return height
    private int DFS(TreeNode curr, ref int res){
        if (curr == null) return 0;

        var left = DFS(curr.left, ref res);
        var right = DFS(curr.right, ref res);

        res = Math.Max(res, left + right);

        return Math.Max(left, right) + 1;

    }
}
