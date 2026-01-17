using System.Collections.Generic;

namespace Solutions.Arrays.Easy;

public static class ContainsDuplicate
{
    public static bool Solution(int[] nums) 
    {
        int n = nums.Length;
        HashSet<int> keys = new HashSet<int>(n);
        for (int i = 0; i < n; ++i)
        {
            if (!keys.Add(nums[i]))
            {
                return true;
            }
        }
        
        return false;
    }
}