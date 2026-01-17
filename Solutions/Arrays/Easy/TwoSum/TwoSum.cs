using System.Collections.Generic;

namespace Solutions.Arrays.Easy;

public static class TwoSum
{
    public static int[] Solution(int[] nums, int target) 
    {
        int n = nums.Length;
        Dictionary<int, int> discovered = []; // Key[Value] | Value[Index]
        for (int i = 0; i < n; ++i)
        {
            int val = nums[i];
            int needed = target - val;
            if (discovered.TryGetValue(needed, out int j))
            {
                return [j, i];
            }
            
            discovered[val] = i;
        }
        
        return [-1, -1];
    }
}