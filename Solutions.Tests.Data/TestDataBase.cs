// <copyright file="TestDataBase.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.Data;

using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Provides a base implementation for fast test cases creation.
/// </summary>
/// <typeparam name="TSelf">The custom type which inherits from this class.</typeparam>
public abstract class TestDataBase<TSelf> : IEnumerable<object[]>
    where TSelf : TestDataBase<TSelf>, new()
{
    /// <summary>
    /// Returns a new instance of the custom type as enumerable test cases.
    /// </summary>
    /// <returns>Enumerable test cases.</returns>
    public static IEnumerable<object[]> GetTestData()
        => new TSelf();

    /// <summary>
    /// Constructs and returns an enumerator of test cases.
    /// </summary>
    /// <returns>An enumerator of test cases.</returns>
    public IEnumerator<object[]> GetEnumerator()
        => this.ConstructTestCases().Build().GetEnumerator();

    /// <summary>
    /// Constructs and return an enumerator of test cases.
    /// </summary>
    /// <returns>An enumerator of test cases.</returns>
    IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();

    /// <summary>
    /// Gives access to a private test case builder.
    /// </summary>
    /// <typeparam name="TArg">The type of the test argument.</typeparam>
    /// <typeparam name="TOut">The type of the test expected output.</typeparam>
    /// <returns>Builder containing test cases.</returns>
    protected static ITestCaseBuilder<TArg, TOut> Cases<TArg, TOut>()
        => new TestCaseBuilder<TArg, TOut>();

    /// <summary>
    /// Constructs test cases.
    /// </summary>
    /// <returns>Builder containing test cases.</returns>
    protected abstract ITestCaseBuilder ConstructTestCases();

    private sealed class TestCaseBuilder<TArg, TOut> : ITestCaseBuilder<TArg, TOut>
    {
        private readonly List<object[]> testDataList = [];

        private Func<TArg, object[]> argConverter = DefaultConverter;
        private Func<TOut, object[]> outputConverter = DefaultConverter;
        private Func<TArg, TOut, object[]>? outputGenerator;

        /// <inheritdoc />
        public IEnumerable<object[]> Build()
        {
            return this.testDataList.ToArray();
        }

        /// <inheritdoc />
        public ITestCaseBuilder<TArg, TOut> DefineCustomArgConverter(Func<TArg, object[]> converter)
        {
            this.argConverter = converter;
            return this;
        }

        /// <inheritdoc />
        public ITestCaseBuilder<TArg, TOut> DefineCustomOutConverter(Func<TOut, object[]> converter)
        {
            this.outputConverter = converter;
            return this;
        }

        /// <inheritdoc />
        public ITestCaseBuilder<TArg, TOut> DefineCustomOutGenerator(Func<TArg, TOut, object[]> generator)
        {
            this.outputGenerator = generator;
            return this;
        }

        /// <inheritdoc />
        public ITestCaseBuilder<TArg, TOut> Add(TArg arg, TOut output)
        {
            object[] cArg = this.argConverter.Invoke(arg);
            object[] cOut = this.outputGenerator == null
                ? this.outputConverter.Invoke(output)
                : this.outputGenerator.Invoke(arg, output);

            int cArgN = cArg.Length;
            int cOutN = cOut.Length;
            object[] data = new object[cArgN + cOutN];
            Array.Copy(cArg, 0, data, 0, cArgN);
            Array.Copy(cOut, 0, data, cArgN, cOutN);

            this.testDataList.Add(data);
            return this;
        }

        /// <summary>
        /// The default converter of both TArg and TOut into object[].
        /// </summary>
        /// <param name="var">The value to be converted.</param>
        /// <typeparam name="T">The type of the converted value.</typeparam>
        /// <returns>The given value converted into object[].</returns>
        private static object[] DefaultConverter<T>(T var)
        {
            return [var!];
        }
    }
}
