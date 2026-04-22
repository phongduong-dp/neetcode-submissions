public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> checkList = new List<int>();

        foreach (var num in nums){
            if (checkList.Contains(num)) {
                return true;
            }

            checkList.Add(num);
        }

        return false;
    }
}
