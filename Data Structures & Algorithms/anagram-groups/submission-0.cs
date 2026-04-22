public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var output = new Dictionary<string,List<string>>();

        foreach (var str in strs){
            var count = new int[26];
            foreach(var s in str){
                //This will return difference between their Unicode (ASCII) values as an integer
                count[s - 'a']++;
            }

            var key = string.Join(",", count);

            if(!output.ContainsKey(key)){
                output[key] = new List<string>();
            }
            
            output[key].Add(str);

        }

        return output.Values.ToList();
    }
}
