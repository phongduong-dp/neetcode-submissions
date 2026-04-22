public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var n = board[0].Length;
        var squareHash = new Dictionary<int, HashSet<char>>();

        for (var i = 0; i < n; i++){
            var rowHash = new HashSet<char>();
            var columnHash = new HashSet<char>();

            for (var j = 0; j < n; j++){
                var squareIndex = (i / 3) * 3 + (j / 3);

                if (board[i][j] != '.'){
                    if (rowHash.Contains(board[i][j])) return false;
                    rowHash.Add(board[i][j]);

                    if (!squareHash.TryGetValue(squareIndex, out var hashSet) || hashSet == null)
                    {
                        hashSet = new HashSet<char>();
                        squareHash[squareIndex] = hashSet;
                    }

                    if (squareHash[squareIndex].Contains(board[i][j])) return false;

                    squareHash[squareIndex].Add(board[i][j]);
                }

                if (board[j][i] != '.'){
                    if (columnHash.Contains(board[j][i])) return false;
                    columnHash.Add(board[j][i]);
                }

            }
        }

        return true;
        
    }
}
