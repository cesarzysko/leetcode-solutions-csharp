using System;

namespace Solutions.Arrays.Easy.PlusOne
{
    public static class PlusOne
    {
        public static int[] Solution(int[] digits) 
        {
            return Recursive(digits, digits.Length - 1);
        }
    
        private static int[] Recursive(int[] digits, int lastIndex)
        {
            if (digits[lastIndex] == 9)
            {
                if (lastIndex == 0)
                {
                    Array.Resize(ref digits, digits.Length + 1);
                    for (int i = digits.Length - 2; i >= 0; --i)
                    {
                        digits[i + 1] = digits[i];
                    }
                
                    digits[1] = 0;
                    digits[0] = 1;
                    return digits;
                }
            
                digits[lastIndex] = 0;
                return Recursive(digits, lastIndex - 1);
            }
        
            ++digits[lastIndex];
            return digits;
        }
    }
}
