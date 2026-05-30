public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int res =0, cnt = 0;
        foreach (var num in nums)
        {
            if (num == 0)
            {
                res = Math.Max(res, cnt);
                cnt =0;
            }
            else {
                cnt++;
            }
        }
        return Math.Max(res,cnt);
    }
}