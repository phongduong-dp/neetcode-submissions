public class Solution {
    public int Search(int[] nums, int target) {
        return Array.BinarySearch(nums, target) >= 0 ? Array.BinarySearch(nums, target) : -1 ;
    }
}
