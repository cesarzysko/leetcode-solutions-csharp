namespace Solutions.Tests.MSTest;

using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public sealed class FromTestDataAttribute(Type dataType) : Attribute, ITestDataSource
{
    private const BindingFlags Flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;

    private readonly Type dataType = dataType ?? throw new ArgumentNullException(nameof(dataType));

    IEnumerable<object[]> ITestDataSource.GetData(MethodInfo methodInfo)
    {
        MethodInfo? method = this.dataType.GetMethod("GetTestData", Flags);
        if (method == null)
        {
            throw new InvalidOperationException($"{this.dataType.Name} must have a public static GetTestData() method.");
        }

        var result = method.Invoke(null, null);
        return result as IEnumerable<object[]> ?? throw new InvalidOperationException("GetTestData() must return IEnumerable<object[]>.");
    }

    string ITestDataSource.GetDisplayName(MethodInfo methodInfo, object?[]? data)
    {
        return $"{methodInfo.Name}({string.Join(", ", data!)})";
    }
}