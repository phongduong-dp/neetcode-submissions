public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach(var s in strs){
            var count = new int[26];

            foreach (var c in s){
                count[c - 'a']++;
            }

            var key = string.Join(",", count);
            if (!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }

        return res.Values.ToList<List<string>>();
    }

    public bool IsAnargram(string s , string t){
        if (s.Length != t.Length) return false;

        var stringS = new Dictionary<char,int>();
        var stringT = new Dictionary<char,int>();

        for (var i = 0; i < s.Length; i++){
            if (stringS.ContainsKey(s[i])){
                stringS[s[i]]++;
            }else{
                stringS[s[i]] = 1;
            }

            if (stringT.ContainsKey(t[i])){
                stringT[t[i]]++;
            }else{
                stringT[t[i]] = 1;
            }
        }

        foreach (var c in stringS.Keys){
            if (!stringT.ContainsKey(c) || stringS[c] != stringT[c]) return false;
        }

        return true;
        
    }
}