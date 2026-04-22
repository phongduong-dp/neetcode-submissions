public class Solution {
    public bool IsPalindrome(string s) {
        var l = 0;
        var r = s.Length - 1;
        var cleanedStr = s.Trim().ToLower();

         while (l < r){
            if (!Char.IsLetterOrDigit(cleanedStr[l])){
                l++;
            }else if (!Char.IsLetterOrDigit(cleanedStr[r])){
                r--;
            }else if (Char.ToLower(cleanedStr[r]) != Char.ToLower(cleanedStr[l])){
                return false;
            }else{
                l++;
                r--;
            }
        }

        return true;
    }
}
