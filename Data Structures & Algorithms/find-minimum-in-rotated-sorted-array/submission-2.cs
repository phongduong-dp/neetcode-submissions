public class Solution {
    public int FindMin(int[] nums) {

        var l = 0;
        var r = nums.Length - 1;

        while (l < r){
            var mid = (l + r) / 2;

            if (nums[mid] < nums[r]){
                r = mid;
            }else{
                l = mid + 1;
            }

        }
        return nums[l];
    }
}
