public class EvaluateReversePolishNotation {
    public int EvalRPN(string[] tokens) {
        Stack<int> eval = new();
        eval.Push(int.Parse(tokens[0]));
        HashSet<string> operate = new HashSet<string>{"+", "-", "*", "/"}; 
        for(int i=1; i<tokens.Length; i++){
            var token = tokens[i];
            if(operate.Contains(token)){
                var num2 = eval.Pop();
                var num1 = eval.Pop();
                var result = calculate(num1,num2,token);
                eval.Push(result);
            }else{
                var num = int.Parse(token);
                eval.Push(num);
            }
        }
        return eval.Peek();
        
    }
    private int calculate(int n1, int n2, string operate){

        return operate switch{
            "+" => n1 + n2,
            "-" => n1 - n2,
            "*" => n1 * n2,
            "/" => n1 / n2,
            _ => throw new Exception("invalid operator")
        };
    }
}