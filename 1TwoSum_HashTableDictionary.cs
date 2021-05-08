public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> store = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (store.ContainsKey(diff))
                    return new int[]{ i, store[diff] };
            else
                    store.TryAdd(nums[i], i);
            }

            return new int[] { -1, -1 };
    }
}
