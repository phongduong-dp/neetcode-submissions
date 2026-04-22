public class Solution {
    public int LongestConsecutive(int[] nums) {
        //Hash set will remove all duplicated values in nums
        var numsSet = new HashSet<int>(nums);
        var res = 0;

        foreach(var num in numsSet){
            if (numsSet.Contains(num - 1)) continue;

            var length = 1;
            
            while (numsSet.Contains(num + length)){
                length++;
            }
            res = Math.Max(res, length);
            
        }
        return res;

    }
}
