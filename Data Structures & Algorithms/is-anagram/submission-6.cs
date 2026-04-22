public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        
        var list1 = new Dictionary<char, int>();
        var list2 = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++){
            if (list1.ContainsKey(s[i])){
                list1[s[i]]++;
            }else{
                list1[s[i]] = 1;
            }

            if (list2.ContainsKey(t[i])){
                list2[t[i]]++;
            }else{
                list2[t[i]] = 1;
            }
        }

        foreach(var c in list1.Keys){
            if (!list2.ContainsKey(c) || list1[c] != list2[c]) return false;
        }

        return true;
    }
}
