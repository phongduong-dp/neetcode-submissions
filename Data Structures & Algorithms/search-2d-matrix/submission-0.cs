public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var nr = matrix.Length;
        var nc = matrix[0].Length;

        var top = nr - 1;
        var bot = 0;
        var l = 0;
        var r = nc - 1;
        var row = 0;

        while (bot <= top){
            row = (top + bot) / 2;
            if (target > matrix[row][nc - 1]){
                bot = row + 1;
            }
            else if (target < matrix[row][0]){
                top = row - 1;
            }else{
                break;
            }

        }

        if (!(bot <= top)) return false;

        while (l <= r){
            var mid = (l + r) / 2;
            if (target > matrix[row][mid]){
                l = mid + 1;
            }else if (target < matrix[row][mid]){
                r = mid - 1;
            }else{
                return true;
            }
        }

        return false;

    }
}
