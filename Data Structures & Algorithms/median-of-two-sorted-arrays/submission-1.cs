public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var mergedArr = nums1.Concat(nums2).ToArray();
        var n = mergedArr.Length - 1;

        Array.Sort(mergedArr);

        var half1 = (int)n / 2;
        var half2 = (int)Math.Ceiling((double)n / 2);

        var res = (double)(mergedArr[half1] + mergedArr[half2]) / 2;

        return res;

    }
}
