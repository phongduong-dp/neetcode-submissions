public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        
        var countS = new Dictionary<char,int>();
        var countT = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++){
            // Update countS for character s[i]
            if (countS.ContainsKey(s[i])) {
                countS[s[i]]++;
            } else {
                countS[s[i]] = 1;
            }

            // Update countT for character t[i]
            if (countT.ContainsKey(t[i])) {
                countT[t[i]]++;
            } else {
                countT[t[i]] = 1;
            }
        }

        foreach (var c in countS.Keys){
            if (!countT.ContainsKey(c) || countS[c] != countT[c]) return false;
        }

        return true;


    }
}
