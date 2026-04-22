public class Solution {
    public bool hasDuplicate(int[] nums) {
        var trackedSet = new HashSet<int>();

        foreach(var num in nums){
            if (trackedSet.Contains(num)) return true;

            trackedSet.Add(num);
        }

        return false;

    }
}
