public class SolutDailyTemperatures{
    //brute
    // public int[] DailyTemperatures(int[] temperatures) {
    //     List<int> answers= new List<int>();
    //     for(int i=0;i<temperatures.Length;i++){
    //         int temperature = temperatures[i];
    //         int nextWarmerDay = 0;
    //         for(int j = i+1; j<temperatures.Length;j++){
    //             if(temperatures[j]>temperature){
    //                 nextWarmerDay=j-i;
    //                 break;
    //             }
    //         }
    //         answers.Add(nextWarmerDay);
    //     }
    //     return answers.ToArray();
    // }

    //use stack
    public int[] DailyTemperatures(int[] temperatures) {
        int[] answers = new int[temperatures.Length];
        Stack<int> stack = new(){};
        stack.Push(0);
        for(int i=1;i<temperatures.Length;i++){
            while(stack.Count != 0 && temperatures[stack.Peek()] < temperatures[i]){
                int index = stack.Pop();
                answers[index] = i-index;
            }
            stack.Push(i);
        }
        answers[temperatures.Length-1] = 0;
        return answers;   
    }
}