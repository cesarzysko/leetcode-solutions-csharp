namespace Solutions.Strings.Easy
{
    public static class ReverseInteger
    {
        public static int Solution(int x) 
        {
            long reverse = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                reverse = reverse * 10 + pop;
                if (reverse < int.MinValue || reverse > int.MaxValue)
                {
                    return 0;
                }
            }
        
            return (int)reverse;
        }
    }
}
