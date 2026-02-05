// <copyright file="ITestCaseBuilder.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data;

using System;
using System.Collections.Generic;

/// <summary>
/// Interface used for test case creation.
/// </summary>
public interface ITestCaseBuilder
{
    /// <summary>
    /// Returns test cases created via the builder.
    /// </summary>
    /// <returns>Enumerable test cases.</returns>
    IEnumerable<object[]> Build();
}

/// <summary>
/// INterface used for more streamlined test case creation.
/// </summary>
/// <typeparam name="TArg">The type of the test argument.</typeparam>
/// <typeparam name="TOut">The type of the test expected output.</typeparam>
public interface ITestCaseBuilder<TArg, TOut> : ITestCaseBuilder
{
    /// <summary>
    /// Used to define a custom converter from TArg to object[].
    /// </summary>
    /// <param name="converter">The converter to be used on every test argument.</param>
    /// <returns>Self.</returns>
    ITestCaseBuilder<TArg, TOut> DefineCustomArgConverter(Func<TArg, object[]> converter);

    /// <summary>
    /// Used to define a custom converter from TOut to object[].
    /// </summary>
    /// <param name="converter">The converter to be used on every test expected output.</param>
    /// <returns>Self.</returns>
    ITestCaseBuilder<TArg, TOut> DefineCustomOutConverter(Func<TOut, object[]> converter);

    /// <summary>
    /// Used to define a custom converter from TOut to object[].
    /// </summary>
    /// <param name="generator">The generator to be used to generate expected output based on TArg and TOut values.</param>
    /// <returns>Self.</returns>
    ITestCaseBuilder<TArg, TOut> DefineCustomOutGenerator(Func<TArg, TOut, object[]> generator);

    /// <summary>
    /// Used to add a new test case.
    /// </summary>
    /// <param name="arg">The test argument.</param>
    /// <param name="output">The test expected output.</param>
    /// <returns>Self.</returns>
    ITestCaseBuilder<TArg, TOut> Add(TArg arg, TOut output);
}
