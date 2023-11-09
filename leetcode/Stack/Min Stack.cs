public class MinStack {
    LinkedList<(int,int)> stack;
    public MinStack() {
        stack = new LinkedList<(int,int)>();
    }
    
    public void Push(int val) {
        if(stack.Count == 0){
            stack.AddFirst((val,val));
        }else{
            (_, int currentMin) = stack.First();
            stack.AddFirst((val, Math.Min(currentMin, val)));
        }
    }
    
    public void Pop() {
        stack.RemoveFirst();
    }
    
    public int Top() {
        (int last, _) = stack.First();
        return last;
    }
    
    public int GetMin() {
        (_, int currentMin) = stack.First();
        return currentMin;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */