// <copyright file="FromTestDataAttribute.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest;

using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Custom attribute for MSTest which works similarly to NUnit/TestCaseSource or xUnit/ClassData attributes.
/// </summary>
/// <param name="dataType">The type from which the test data is gathered.</param>
[AttributeUsage(AttributeTargets.Method)]
public sealed class FromTestDataAttribute(Type dataType) : Attribute, ITestDataSource
{
    private const BindingFlags Flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;

    private readonly Type dataType = dataType ?? throw new ArgumentNullException(nameof(dataType));

    /// <inheritdoc/>
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

    /// <inheritdoc/>
    string ITestDataSource.GetDisplayName(MethodInfo methodInfo, object?[]? data)
    {
        return $"{methodInfo.Name}({string.Join(", ", data!)})";
    }
}
