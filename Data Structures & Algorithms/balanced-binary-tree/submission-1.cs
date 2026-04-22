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
        return DFS(root).Item1;
    }

    private Tuple<bool, int> DFS(TreeNode root){
        if (root == null) return new Tuple<bool , int>(true , 0);

        var left = DFS(root.left);
        var right = DFS (root.right);

        var balanced =  (left.Item1 && right.Item1) && ( Math.Abs(left.Item2 - right.Item2) <= 1 );

        return new Tuple<bool, int>(balanced, 1 + Math.Max(left.Item2, right.Item2));

    }
}
