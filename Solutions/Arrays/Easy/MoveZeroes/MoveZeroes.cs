namespace Solutions.Arrays.Easy
{
    public static class MoveZeroes
    {
        public static void Solution(int[] nums) 
        {
            int n = nums.Length;
            int w = 0;
            for (int i = 0; i < n; ++i)
            {
                int num = nums[i];
                if (num != 0)
                {
                    nums[w++] = num;
                }
            }
        
            while (w < n)
            {
                nums[w++] = 0;
            }
        }
    }
}
