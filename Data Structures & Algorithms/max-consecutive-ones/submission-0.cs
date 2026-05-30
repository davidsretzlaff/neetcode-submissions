public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int res = 0;
        int len = nums.Length;
        int count = 0;
        for (int i = 0; i < len; i++)
        {
            count = 0;
            for (int j = i; j < len; j++)
            {
                if (nums[i] != 1 || nums[j] != 1)
                    break;
                count = count +1;
            }
            res = Math.Max(count, res);
        }

        return res;
    }
}