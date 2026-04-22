public class Solution {
    public bool IsPalindrome(string s) {
        var trimStr = s.Trim().ToLower();
        var cleanedStr = trimStr.Where(c => Char.IsLetterOrDigit(c)).ToArray();
        var length = cleanedStr.Length;
        var check = false;

        if (length == 0) return true;

        for (var i = 0; i <= length / 2; i++){
            if (cleanedStr[i] == cleanedStr[length - i - 1]){
                check = true;
            }else{
                return false;
            }
        }

        return check;
    }
}
