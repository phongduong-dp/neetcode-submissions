public class Solution {
    public int MaxArea(int[] heights) {
        var res = 0;        
        var i = 0;
        var j = heights.Length - 1;

        while (i < j){
            var area = (j - i) * Math.Min(heights[i], heights[j]);

            if (area > res){
                res = area;
                if (heights[i] > heights[j]){
                    j--;
                }else{
                    i++;
                }
            }else{
                if (heights[i] > heights[j]){
                    j--;
                }else{
                    i++;
                }
            }

        }

        return res;
    }
}
