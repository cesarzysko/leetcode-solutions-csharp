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
    /// <param name="s"></param>
    /// <returns></returns>
    public static int Solution(string s)
    {
        int i = 0;
        int n = s.Length;
        StringBuilder numBuilder = new(n);

        while (i < n && s[i] == ' ')
        {
            ++i;
        }

        if (i < n && (s[i] == '-' || s[i] == '+'))
        {
            numBuilder.Append(s[i++]);
        }

        while (i < n && char.IsDigit(s[i]))
        {
            numBuilder.Append(s[i++]);
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