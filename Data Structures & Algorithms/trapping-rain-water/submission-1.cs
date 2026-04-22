public class Solution {
    public int Trap(int[] height) {
        var n = height.Length;
        if(n == 0 ) return 0;

        var prefix = new int[n];
        var suffix = new int[n];
        var currentArr = new List<int>();

        var res = 0;

        //Prepare prefix array
        for (var i = 0 ; i < n ; i++){
            if (currentArr.Count == 0) {
                prefix[i] = 0;
                currentArr.Add(height[i]);
                continue;
            }
            prefix[i] = currentArr.Max();
            currentArr.Add(height[i]);
        }

        //Prepare suffix array
        currentArr.Clear();
        for (var i = n - 1 ; i >= 0 ; i--){
            if (currentArr.Count == 0) {
                suffix[i] = 0;
                currentArr.Add(height[i]);
                continue;
            }
            suffix[i] = currentArr.Max();
            currentArr.Add(height[i]);
        }

        for (var i = 0 ; i < n ; i++){
            var sum = Math.Min(prefix[i], suffix[i]) - height[i];

            if (sum < 0) continue;

            res += sum;

        }

        return res;
    }
}
