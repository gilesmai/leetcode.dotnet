public class CF{
    //use stack
    public int CarFleet(int target, int[] position, int[] speed) {
        //cas: (position, timeAtTarget)
        var cars = new List<(decimal, decimal)>();
        for(int i=0; i<position.Length;i++){
            decimal d1= position[i];
            decimal d2= speed[i];
            cars.Add((d1, (target-d1)/d2));
        }
        //sort by car's position
        cars = cars.OrderBy(c=>c.Item1).ToList();
        var stack = new Stack<decimal>();
        stack.Push(cars[0].Item2);
        for(int i=1; i<cars.Count; i++){
            //if the top car in stack use less time than car[i], these two car must meet before target
            //so pop the top car as they will eventually become one fleet
            while(stack.Count>0 &&cars[i].Item2>=stack.Peek()){
                stack.Pop();
            }
            //push the current time to stack as the faster car will slow down to match the slower car's speed
            //so the arrival time of the new fleet is the arrival time of cars[i]
            stack.Push(cars[i].Item2);
        }
        return stack.Count();
    }

    //use array
    public int CarFleet1(int target, int[] position, int[] speed) {
        var times = new (int,double)[position.Length];
        for(int i=0;i<position.Length;i++){
            times[i] = (position[i], (target-position[i])*1.0/(speed[i]*1.0));
        }
        //sort by car's position
        Array.Sort(times, new Comparison<(int,double)>((t1, t2)=>t1.Item1.CompareTo(t2.Item1)));
        
        var slowest = double.MinValue; //the largetest time to arrive to target
        var count = 0;
        for(int i = times.Length-1; i>=0;i--){
            //if current car's time to target(times[i].Item2) is greater than the slowest time,
            //then current car will never meet the slowest fleet
            //hence, there will be a new fleet and the slowest fleet will be current car
            if(times[i].Item2>slowest){
                count ++;
                slowest = times[i].Item2;
            }
        }
        return count;
    }
}