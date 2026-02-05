namespace Solutions.Tests.Data;

using System;
using System.Collections;
using System.Collections.Generic;

public abstract class TestDataBase<TSelf> : IEnumerable<object[]>
    where TSelf : TestDataBase<TSelf>, new()
{
    public static IEnumerable<object[]> GetTestData()
        => new TSelf();

    public IEnumerator<object[]> GetEnumerator()
        => this.ConstructTestCases().Build().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();

    protected abstract ITestCaseBuilder ConstructTestCases();

    protected static ITestCaseBuilder<TArg, TOutput> Cases<TArg, TOutput>()
        => new TestCaseBuilder<TArg, TOutput>();

    private sealed class TestCaseBuilder<TArg, TOut> : ITestCaseBuilder<TArg, TOut>
    {
        private readonly List<object[]> testData = [];

        private Func<TArg, object[]> argConverter = DefaultConverter;
        private Func<TOut, object[]> outputConverter = DefaultConverter;
        private Func<TArg, TOut, object[]>? outputGenerator;

        public IEnumerable<object[]> Build()
        {
            return this.testData.ToArray();
        }

        public ITestCaseBuilder<TArg, TOut> DefineCustomArgConverter(Func<TArg, object[]> converter)
        {
            this.argConverter = converter;
            return this;
        }

        public ITestCaseBuilder<TArg, TOut> DefineCustomOutConverter(Func<TOut, object[]> converter)
        {
            this.outputConverter = converter;
            return this;
        }

        public ITestCaseBuilder<TArg, TOut> DefineCustomOutGenerator(Func<TArg, TOut, object[]> generator)
        {
            this.outputGenerator = generator;
            return this;
        }

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

            this.Add(data);
            return this;
        }

        private static object[] DefaultConverter<T>(T var)
        {
            return [var!];
        }

        private void Add(object[] testData)
        {
            this.testData.Add(testData);
        }
    }
}

public interface ITestCaseBuilder
{
    IEnumerable<object[]> Build();
}

public interface ITestCaseBuilder<TArg, TOut> : ITestCaseBuilder
{
    ITestCaseBuilder<TArg, TOut> DefineCustomArgConverter(Func<TArg, object[]> converter);

    ITestCaseBuilder<TArg, TOut> DefineCustomOutConverter(Func<TOut, object[]> converter);

    ITestCaseBuilder<TArg, TOut> DefineCustomOutGenerator(Func<TArg, TOut, object[]> generator);

    ITestCaseBuilder<TArg, TOut> Add(TArg arg, TOut output);
}