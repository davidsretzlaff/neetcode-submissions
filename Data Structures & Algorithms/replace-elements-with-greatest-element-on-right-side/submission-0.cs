public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var res = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            int rightMax = -1;
            for (int j = i +1; j < arr.Length; j++)
            {
                rightMax = Math.Max(rightMax, arr[j]);
            }
            res[i] = rightMax;
        }
        return res;
    }
}