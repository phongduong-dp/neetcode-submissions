public class Solution {
    public int FindDuplicate(int[] nums) {
        var fast = 0;
        var slow = 0;

        while (true){
            slow = nums[slow];
            fast = nums[nums[fast]];

            if (slow == fast){
                break;
            }
        }

        var slow2 = 0;
        while (true){
            slow = nums[slow];
            slow2 = nums[slow2];

            if (slow == slow2){
                return slow;
            }
        }

        return 0;
    }
}
