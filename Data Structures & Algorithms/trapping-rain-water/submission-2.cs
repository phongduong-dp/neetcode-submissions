public class Solution {
    public int Trap(int[] height) {
        var n = height.Length;
        if( n == 0 || height == null) return 0;
        var res = 0;
        var l = 0;
        var r = n - 1;
        var leftMax = height[l];
        var rightMax = height[r];

        while (l < r){
            if(height[l] < height[r]){
                l++;
                leftMax = Math.Max(height[l], leftMax);
                res += leftMax - height[l];
            }else{
                r--;
                rightMax = Math.Max(height[r], rightMax);
                res+= rightMax - height[r];
            }
        }

        return res;
    }
}
