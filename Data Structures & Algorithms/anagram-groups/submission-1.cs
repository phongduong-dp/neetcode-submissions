public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new List<List<string>>();
        var visited = new bool[strs.Length];

        for (var i = 0; i < strs.Length; i++){
            if (visited[i]) continue;
            var curr = new List<string>();
            curr.Add(strs[i]);
            visited[i] = true;
            for (var j = i + 1; j < strs.Length; j++){
                if (!visited[j] && IsAnargram(strs[i], strs[j])){
                    curr.Add(strs[j]);
                    visited[j] = true;
                }
            }

            res.Add(curr);
        }

        return res;
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