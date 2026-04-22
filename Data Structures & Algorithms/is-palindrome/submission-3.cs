public class Solution {
    public bool IsPalindrome(string s) {
        var l = 0;
        var r = s.Length - 1;

        while (l < r){
            if (!Char.IsLetterOrDigit(s[l])){
                l++;
            }else if (!Char.IsLetterOrDigit(s[r])){
                r--;
            }else if (Char.ToLower(s[r]) != Char.ToLower(s[l])){
                return false;
            }else{
                l++;
                r--;
            }
        }

        return true;
    }
}
