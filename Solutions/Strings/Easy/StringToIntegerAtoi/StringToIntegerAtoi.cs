// <copyright file="StringToIntegerAtoi.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Strings.Easy;

using System;
using System.Text;

/// <summary>
/// Class implementing a solution to the "String to Integer (atoi)" LeetCode problem.
/// </summary>
public static class StringToIntegerAtoi
{
    /// <summary>
    /// Implementation of the "String to Integer (atoi)" LeetCode problem.
    /// </summary>
    /// <param name="str">The string to be converted into an integer.</param>
    /// <returns>The string converted to an integer, or 0 if invalid.</returns>
    public static int Solution(string str)
    {
        int i = 0;
        int n = str.Length;
        StringBuilder numBuilder = new(n);

        while (i < n && str[i] == ' ')
        {
            ++i;
        }

        if (i < n && (str[i] == '-' || str[i] == '+'))
        {
            numBuilder.Append(str[i++]);
        }

        while (i < n && char.IsDigit(str[i]))
        {
            numBuilder.Append(str[i++]);
        }

        string num = numBuilder.ToString();
        if (string.IsNullOrEmpty(num) || (num.Length == 1 && (num[0] == '-' || num[0] == '+')))
        {
            return 0;
        }

        try
        {
            return int.Parse(num);
        }
        catch (Exception)
        {
            Console.WriteLine(num);
            return num[0] == '-'
                ? int.MinValue
                : int.MaxValue;
        }
    }
}