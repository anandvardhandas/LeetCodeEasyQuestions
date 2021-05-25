public class Solution {
    public int ClimbStairs(int n) {
        if(n == 1 || n == 2)
            return n;
        
        int sum = 0, n1 = 1, n2 = 2;
        for(int i = 3; i <= n; i++)
        {
            sum = n1+n2;
            n1 = n2;
            n2 = sum;
        }
        
        return sum;
    }
}
