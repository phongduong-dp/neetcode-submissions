public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var countDict = new Dictionary<int,int>();

        //Initialize the count array
        var freq = new List<int>[nums.Length + 1];
        for (int i = 0; i <freq.Length;i++){
            freq[i] = new List<int>();
        }

        //Create a dictionary with keys are the number in input
        // Values are there count
        foreach(var num in nums){
            if(countDict.ContainsKey(num)){
                countDict[num]++;
            }else{
                countDict[num] = 1;
            }
        }

        foreach(var items in countDict){
            freq[items.Value].Add(items.Key);
        }

        var result = new int[k];
        var index = 0;

        for (int i = freq.Length - 1; i > 0 && index < k; i--){
            foreach(int n in freq[i]){
                result[index] = n;
                index++;
                if (index == k){
                    return result;
                }
            }
        }
        
        return result;
    }
}
