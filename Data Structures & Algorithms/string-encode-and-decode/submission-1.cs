public class Solution {

    public string Encode(IList<string> strs) {
        var res = "";
        foreach (var str in strs){
            res += str.Length.ToString() + "#" + str;
        }

        return res;
    }

    public List<string> Decode(string s) {
        var i = 0;
        var res = new List<string>();

        while(i < s.Length){
            var j = i;
            while (s[j] != '#'){
                j ++;
            }
            var length = int.Parse(s.Substring(i, j - i));
            res.Add(s.Substring(j + 1, length));
            i = j + 1 + length;
        }
        
        return res;
    }
}
