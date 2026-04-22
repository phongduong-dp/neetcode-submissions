public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexMap = new Dictionary<int,int>();

        for (var i = 0; i < nums.Length; i++){
            var diff = target - nums[i];
            if (indexMap.ContainsKey(diff)){
                return new [] {indexMap[diff], i};
            }

            indexMap[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
