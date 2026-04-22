public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while (l < r){

            var mid = (l+r)/2;
            if (nums[mid] < nums[r]){
                r = mid;
            }else{
                l = mid;
            }
            if (r - l == 1) break;
        }

        if (target <= nums[l] && target >= nums[0]){
            r = l;
            l = 0;
            while (l <= r){
                var mid = (l + r) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] < target){
                    l = mid + 1;
                }else{
                    r = mid - 1;
                }
            }
        }else{
            l = r;
            r = nums.Length - 1;
            while (l <= r){
                var mid = (l + r) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] < target){
                    l = mid + 1;
                }else{
                    r = mid - 1;
                }
            }
        }
        return -1;
    }
}
