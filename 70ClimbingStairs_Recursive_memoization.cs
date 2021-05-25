public class Solution {
    public int ClimbStairs(int n) {
        if(n == 0)
            return n;
        int[] result = new int[n+1];
        return Helper(result, n);
    }
    
    private int Helper(int[] result, int n)
    {
        if(result[n] != 0)
            return result[n];
        
        if(n == 1 || n == 2)
        {
            result[n] = n;
            return result[n];
        }
            
        
        result[n] = Helper(result, n-1) + Helper(result, n-2);
        return result[n];
    }
}
