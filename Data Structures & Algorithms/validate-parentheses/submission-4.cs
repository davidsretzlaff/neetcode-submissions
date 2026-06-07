public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var dic = new Dictionary<char,char>();
        dic[']'] = '[';
        dic[')'] = '(';
        dic['}'] = '{';

        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                if (stack.Count > 0 && dic[s[i]] == stack.Peek())
                    stack.Pop(); 
                else 
                    return false;
            }            
            else
                stack.Push(s[i]);
        }
        return stack.Count == 0;
    }
}
