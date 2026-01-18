using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Tests.Data;

public abstract class TestDataBase<TSelf> : IEnumerable<object[]> 
    where TSelf : TestDataBase<TSelf>, new()
{
    public static IEnumerable<object[]> GetTestData()
        => new TSelf();

    public IEnumerator<object[]> GetEnumerator()
        => ConstructTestCases().Build().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() 
        => GetEnumerator();

    protected abstract ITestCaseBuilder ConstructTestCases();

    protected static ITestCaseBuilder<TArg, TOutput> Cases<TArg, TOutput>()
        => new TestCaseBuilder<TArg, TOutput>();

    protected static ITestCaseBuilder<TArg1, TArg2, TOutput> GetTestCaseBuilder<TArg1, TArg2, TOutput>()
        => new TestCaseBuilder<TArg1, TArg2, TOutput>();
    
    // Test cases
    private interface ITestCase
    {
        object[] Convert();
    }

    private sealed record TestCase<TArg, TOutput>(
        TArg Arg,
        TOutput Output
    ) : ITestCase
    {
        object[] ITestCase.Convert()
            => [Arg!, Output!];
    }

    private sealed record TestCase<TArg1, TArg2, TOutput>(
        TArg1 Arg1,
        TArg2 Arg2,
        TOutput Output
    ) : ITestCase
    {
        object[] ITestCase.Convert()
            => [Arg1!, Arg2!, Output!];
    }

    // Test case builders
    private abstract class TestCaseBuilderBase : ITestCaseBuilder
    {
        private readonly List<ITestCase> _list = [];
        
        IEnumerable<object[]> ITestCaseBuilder.Build()
        {
            return _list.Select(testCase => testCase.Convert());
        }

        protected void Add(ITestCase testCase)
        {
            _list.Add(testCase);
        }
    }

    private sealed class TestCaseBuilder<TArg, TOutput> : TestCaseBuilderBase, ITestCaseBuilder<TArg, TOutput>
    {
        public ITestCaseBuilder<TArg, TOutput> Add(TArg arg, TOutput output)
        {
            ITestCase testCase = new TestCase<TArg, TOutput>(arg, output);
            Add(testCase);
            return this;
        }

        public ITestCaseBuilder<TArg, TOutput> Add(TArg arg, Func<TArg, TOutput> outputFactory)
        {
            TOutput output = outputFactory(arg);
            return Add(arg, output);
        }
    }

    private sealed class TestCaseBuilder<TArg1, TArg2, TOutput> : TestCaseBuilderBase, ITestCaseBuilder<TArg1, TArg2, TOutput>
    {
        public ITestCaseBuilder<TArg1, TArg2, TOutput> Add(TArg1 arg1, TArg2 arg2, TOutput output)
        {
            ITestCase testCase = new TestCase<TArg1, TArg2, TOutput>(arg1, arg2, output);
            Add(testCase);
            return this;
        }
    }
}

public interface ITestCaseBuilder
{
    IEnumerable<object[]> Build();
}

public interface ITestCaseBuilder<TArg, in TOutput> : ITestCaseBuilder
{
    ITestCaseBuilder<TArg, TOutput> Add(TArg arg, TOutput output);
    
    ITestCaseBuilder<TArg, TOutput> Add(
        TArg arg,
        Func<TArg, TOutput> outputFactory
    );
}

public interface ITestCaseBuilder<in TArg1, in TArg2, in TOutput> : ITestCaseBuilder
{
    ITestCaseBuilder<TArg1, TArg2, TOutput> Add(TArg1 arg1, TArg2 arg2, TOutput output);
}