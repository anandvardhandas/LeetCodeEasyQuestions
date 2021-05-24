public class Solution {
    public int MaxSubArray(int[] nums) {
        return MaxSubarrayDivideConquer(nums, 0, nums.Length - 1);
    }
    
   private int MaxSubarrayDivideConquer(int[] nums, int left, int right){
       
       if(left == right)
           return nums[left];
       
       int mid = left + (right - left)/2;
       int leftMax = MaxSubarrayDivideConquer(nums, left, mid);
       int rightMax = MaxSubarrayDivideConquer(nums, mid+1, right);
       
       int leftSum = int.MinValue;
       int rightSum = int.MinValue;
       int sum = 0;
       
       for(int i = mid; i >=left; i--)
       {
           sum += nums[i];
           if(sum > leftSum)
               leftSum = sum;
       }
       
       sum = 0;
       
       for(int i = mid + 1; i <= right; i++)
       {
           sum += nums[i];
           if(sum > rightSum)
               rightSum = sum;
       }
       
       int midSum = leftSum + rightSum;
       
       //Max of leftMax, rightMax, midSum
       
       int max = leftMax > rightMax ? (leftMax > midSum ? leftMax : midSum) : (rightMax > midSum ? rightMax : midSum);
       return max;
   }
}
