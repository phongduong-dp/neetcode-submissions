public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r){
            var mid = (l + r) / 2;

            if (target == nums[mid]){
                return mid;
            }else if (target > nums[mid]){
                l = mid + 1;
            }else{
                r = mid - 1;
            }

        }

        return -1;
    }
}
