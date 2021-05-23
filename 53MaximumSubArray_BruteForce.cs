public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums == null || nums.Length == 0)
            return 0;
        int max = int.MinValue;
        
        for(int i = 0; i < nums.Length; i++)
        {
            int lsum = 0;
            for(int j = i; j < nums.Length; j++)
            {
                lsum += nums[j];
                if(lsum > max)
                    max = lsum;
            }
        }
        
        return max;
    }
    
   
}
