public class Solution {
    public bool hasDuplicate(int[] nums) {
        var list = new List<int>();

        foreach (var num in nums){
            if (list.Contains(num)){
                return true;
            }
            list.Add(num);
        }
        return false;
    }
}