// <copyright file="PlusOne.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Arrays.Easy;

using System;

/// <summary>
/// Class implementing a solution to the "Plus One" LeetCode problem.
/// </summary>
public static class PlusOne
{
    /// <summary>
    /// Implementation of the "Plus One" LeetCode problem.
    /// </summary>
    /// <param name="digits">An array of digits representing a number.</param>
    /// <returns>An array of digits representing a number after incrementing the given number by one.</returns>
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
