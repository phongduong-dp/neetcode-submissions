public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;
        var res = new int[n];
        var prefix = new int[n];
        var postfix = new int[n];

        prefix[0] = 1;
        postfix[n-1] = 1;

        for (var i = 1 ; i < n ; i++){
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        for(var i = n - 2 ; i >= 0 ; i--){
            postfix[i] = nums[i + 1] * postfix[i + 1];
        }

        for (var i = 0 ; i < n ; i++){
            res[i] = prefix[i] * postfix[i];
        }

        return res;

    }
}
