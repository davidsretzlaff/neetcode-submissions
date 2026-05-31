public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();
        int total = 0;
        foreach (var op in operations) {
            if (op == "+") {
                int top = stack.Pop();
                int newTop = top + stack.Peek();
                stack.Push(top);
                stack.Push(newTop);
                total += newTop;
            } else if (op == "D") {
                total += 2 * stack.Peek();
                stack.Push(2 * stack.Peek());
            } else if (op == "C") {
                total -= stack.Peek();
                stack.Pop();
            } else {
                stack.Push(int.Parse(op));
                total += int.Parse(op);
            }
        }
        return total;
    }
}