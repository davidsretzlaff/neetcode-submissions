public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sdic = new Dictionary<char, int>();
        var tdic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sdic[s[i]] = sdic.GetValueOrDefault(s[i], 0) + 1;
            tdic[t[i]] = tdic.GetValueOrDefault(t[i], 0) + 1;
        }

        return !sdic.Except(tdic).Any();
    }
}
