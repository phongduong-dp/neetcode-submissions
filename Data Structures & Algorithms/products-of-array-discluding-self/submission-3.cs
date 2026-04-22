public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];

        // Compute prefix products and store in res
        int prefix = 1;
        for (var i = 0; i < nums.Length; i++) {
            res[i] = prefix; // Store the current prefix product
            prefix *= nums[i]; // Update prefix
        }

        // Compute postfix products and multiply with the result
        int postfix = 1;
        for (var i = nums.Length - 1; i >= 0; i--) {
            res[i] *= postfix; // Multiply with the postfix product
            postfix *= nums[i]; // Update postfix
        }

        return res;

    }
}
