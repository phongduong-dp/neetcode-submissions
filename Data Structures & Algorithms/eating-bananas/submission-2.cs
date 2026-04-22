public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var n = piles.Length;
        var largestPile = piles.Max();
        var l = 1;
        var r = largestPile;
        var res = r;

        while (l <= r){
            var mid = (l + r) / 2;
            var time = 0;

            foreach (var pile in piles){
                time += (int)Math.Ceiling((double)pile / mid);
            }

            if (time <= h){
                res = mid;
                r = mid - 1;
            }else {
                l = mid + 1;
            }

        }
        
        return res;
        
    }
}
