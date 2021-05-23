public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums == null || nums.Length == 0)
            return 0;
        
        int lsmax = nums[0];
        int smax = nums[0];
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(lsmax + nums[i] > nums[i])
                lsmax += nums[i];
            else
                lsmax = nums[i];
            
            if(lsmax > smax)
                smax = lsmax;
        }
        
           return smax; 
    }
}
