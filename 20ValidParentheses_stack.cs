public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '[' || s[i] == '{' || s[i] == '(')
                st.Push(s[i]);
            else
            {
                if(st.Count == 0)
                    return false;
                
                char popped = st.Pop();
                if((s[i] == '}' && popped != '{') || (s[i] == ']' && popped != '[') || (s[i] == ')' && popped != '('))
                    return false;
            }
        }
        
        if(st.Count == 0)
            return true;
        else
            return false;
    }
}
