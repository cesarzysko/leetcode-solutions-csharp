namespace Solutions.Arrays.Easy
{
    public static class SingleNumber
    {
        public static int Solution(int[] nums) 
        {
            int n = nums.Length;
            int result = 0;
            for (int i = 0; i < n; ++i)
            {
                result ^= nums[i];
            }
        
            return result;
        }
    }
}
