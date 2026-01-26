using System;
using System.Collections;
using System.Collections.Generic;

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

    private sealed class TestCaseBuilder<TArg, TOut> : ITestCaseBuilder<TArg, TOut>
    {
        private readonly List<object[]> _testData = [];
        
        private Func<TArg, object[]> _argConverter = DefaultConverter;
        private Func<TOut, object[]> _outputConverter = DefaultConverter;
        private Func<TArg, TOut, object[]>? _outputGenerator;
        
        public IEnumerable<object[]> Build()
        {
            return _testData.ToArray();
        }
        
        public ITestCaseBuilder<TArg, TOut> DefineCustomArgConverter(Func<TArg, object[]> converter)
        {
            _argConverter = converter;
            return this;
        }

        public ITestCaseBuilder<TArg, TOut> DefineCustomOutConverter(Func<TOut, object[]> converter)
        {
            _outputConverter = converter;
            return this;
        }

        public ITestCaseBuilder<TArg, TOut> DefineCustomOutGenerator(Func<TArg, TOut, object[]> generator)
        {
            _outputGenerator = generator;
            return this;
        }
        
        public ITestCaseBuilder<TArg, TOut> Add(TArg arg, TOut output)
        {
            object[] cArg = _argConverter.Invoke(arg);
            object[] cOut = _outputGenerator == null 
                ? _outputConverter.Invoke(output)
                : _outputGenerator.Invoke(arg, output);

            int cArgN = cArg.Length;
            int cOutN = cOut.Length;
            object[] data = new object[cArgN + cOutN];
            Array.Copy(cArg, 0, data, 0, cArgN);
            Array.Copy(cOut, 0, data, cArgN, cOutN);
            
            Add(data);
            return this;
        }

        private static object[] DefaultConverter<T>(T var)
        {
            return [var!];
        }
        
        private void Add(object[] testData)
        {
            _testData.Add(testData);
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