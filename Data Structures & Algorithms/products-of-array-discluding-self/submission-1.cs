public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];
        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];


        for (var i = 0 ; i < nums.Length ; i++){
            if (i == 0){
                prefix[i] = nums[i];
                continue;
            }
            prefix[i] = prefix[i - 1] * nums[i];
        }

        for(var i = nums.Length - 1 ; i >= 0 ; i--){
            if (i == nums.Length - 1){
                postfix[i] = nums[i];
                continue;
            }
            postfix[i] = nums[i] * postfix[i + 1];
        }

        for (var i = 0 ; i < nums.Length ; i++){
            if (i == 0 ){
                res[i] = postfix[i + 1];
                continue;
            }

            if (i == nums.Length - 1) {
                res[i] = prefix[i - 1];
                continue;
            }

            res[i] = prefix[i - 1] * postfix[i + 1];
        }

        return res;
    }
}
