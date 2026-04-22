public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var l = 0; var r = numbers.Length -1;
        var res = new List<int>();

        while(l < r){

            if (numbers[l] + numbers[r] > target){
                r--;
            } else if (numbers[l] + numbers[r] < target){
                l++;
            } else if (numbers[l] + numbers[r] == target){
                res.Add(l + 1);
                res.Add(r + 1);
                break;
            }
        }

        return res.ToArray();

    }
}
