public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numberIndexMap = new Dictionary<int,int>();

        for (var i = 0; i < nums.Length; i++){
            var difference = target - nums[i];
            if (numberIndexMap.ContainsKey(difference)){
                return new[] {numberIndexMap[difference], i};
            }
            numberIndexMap[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
