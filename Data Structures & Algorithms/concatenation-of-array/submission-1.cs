public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] result = new int[nums.Length * 2];
        int index = 0;
        for (int i = 0; i < 2; i++)
            foreach (var n in nums)
                result[index++] = n;
        return result;
    }
}