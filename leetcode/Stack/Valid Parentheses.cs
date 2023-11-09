using leetcode.Arrays_Hashing;

namespace leetcode.Stack
{
    internal class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            char[] characters = s.ToCharArray();
            Stack<char> validation = new Stack<char>();
            HashSet<char> open = new HashSet<char>{
                '(', '[', '{'};
            HashSet<char> close = new HashSet<char>{')', ']', '}'};
            foreach(var character in characters){
                if(open.Contains(character)){
                    switch(character){
                        case '(':
                            validation.Push(')');
                            break;
                        case '[':
                            validation.Push(']');
                            break;
                        case '{':
                            validation.Push('}');
                            break;                            
                    }
                }else if(close.Contains(character)){
                    if(validation.Count == 0 || validation.Pop() != character){
                        return false;
                    }
                }                
            }
            return validation.Count == 0;
        }
    }
}