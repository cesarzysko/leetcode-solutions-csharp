namespace Solutions.Arrays.Easy
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int Solution(int[] nums)
        {
            int numsCount = nums.Length;
            int k = 0; // Index of last unique number in nums array
            for (int i = 1; i < numsCount; ++i)
            {
                if (nums[k] != nums[i])
                {
                    nums[++k] = nums[i];
                }
            }
        
            return k + 1;
        }
    }
}
