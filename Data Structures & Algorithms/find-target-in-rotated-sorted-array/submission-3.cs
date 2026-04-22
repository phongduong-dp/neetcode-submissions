public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while (l < r){

            var mid = (l+r)/2;
            if (nums[mid] < nums[r]){
                r = mid;
            }else{
                l = mid + 1;
            }
        }

        var pivot = l;
        l = 0;
        r = nums.Length - 1;

        if (target >= nums[pivot] && target <= nums[r]){
            l = pivot;
        }else{
            r = pivot - 1;
        }

        while (l <= r){
                var mid = (l + r) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] < target){
                    l = mid + 1;
                }else{
                    r = mid - 1;
                }
            }
        return -1;
    }
}
