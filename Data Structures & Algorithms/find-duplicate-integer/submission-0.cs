public class Solution {
    public int FindDuplicate(int[] nums) {
        var numSet = new HashSet<int>();

        foreach (var num in nums){
            if (numSet.Contains(num)){
                return num;
            }

            numSet.Add(num);
        }

        return -1;
    }
}
