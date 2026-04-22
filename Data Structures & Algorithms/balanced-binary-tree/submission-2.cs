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
    public bool IsBalanced(TreeNode root) {
        bool balanced = true;

        var height = DFS(root, ref balanced);

        return balanced;
    }

    private int DFS(TreeNode root , ref bool balanced){
        if (root == null) return 0;

        var left = DFS(root.left, ref balanced);
        var right = DFS(root.right, ref balanced);

        if (Math.Abs(left - right) > 1){
            balanced = false;
        }

        return 1 + Math.Max(left, right);

    }
}
