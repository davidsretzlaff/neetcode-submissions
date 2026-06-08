public class MinStack {

    public Stack<int> stack;
    public Stack<int> minValue;
    public MinStack() {
        stack = new Stack<int>();
        minValue = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minValue.Count == 0)
        {
            minValue.Push(val);
            return;
        }
        if (val < minValue.Peek())
            minValue.Push(val);            
        else 
            minValue.Push(minValue.Peek());
            
    }
    
    public void Pop() {
        stack.Pop();
        minValue.Pop();

    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minValue.Peek();
    }
}
