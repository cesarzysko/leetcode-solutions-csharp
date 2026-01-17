using System;

namespace Solutions.Arrays.Easy;

public static class PlusOne
{
    public static int[] Solution(int[] digits) 
    {
        return Recursive(digits, digits.Length - 1);
    }

    private static int[] Recursive(int[] digits, int lastIndex)
    {
        while (true)
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
                --lastIndex;
                continue;
            }

            ++digits[lastIndex];
            return digits;
        }
    }
}