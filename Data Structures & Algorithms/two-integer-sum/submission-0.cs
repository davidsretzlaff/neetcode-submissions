public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.ContainsKey(nums[i]))
                return new int[] { hash[nums[i]], i };

            hash[target - nums[i]] = i;
        }

        return new int[]{};
    }
}
