#if !NETSTANDARD2_0 && !NETSTANDARD2_1
using NUnit.Framework;
#else
using Sondor.Errors.Exceptions;
#endif
using System.Diagnostics.CodeAnalysis;

namespace Sondor.Errors.Tests;

/// <summary>
/// Collection of test assertions.
/// </summary>
#if !NETSTANDARD2_0 && !NETSTANDARD2_1
[ExcludeFromCodeCoverage(Justification = "Intended for external use, to improve testability of the package.")]
#else
[ExcludeFromCodeCoverage]
#endif
public static class SondorErrorAssert
{
    /// <summary>
    /// Asserts that <paramref name="error"/> matches the provided <paramref name="expected"/>.
    /// </summary>
    /// <param name="error">The error.</param>
    /// <param name="expected">The expected.</param>
    public static void AssertError(SondorError? error, SondorError? expected)
    {
        if (error is null && expected is null)
        {
            return;
        }

        if (error is null && expected is not null)
        {
#if !NETSTANDARD2_0 && !NETSTANDARD2_1
            Assert.Fail("Received error is null, but was not expected to be.");

            return;
#else
            throw new SondorAssertionException("Received error is null, but was not expected to be.");
#endif
        }

        if (error is not null && expected is null)
        {
#if !NETSTANDARD2_0 && !NETSTANDARD2_1
            Assert.Fail("Received error is not null, but was expected to be.");
            
            return;
#else
            throw new SondorAssertionException("Received error is not null, but was expected to be.");
#endif
        }

        if (error is null || expected is null)
        {
            return;
        }

#if !NETSTANDARD2_0 && !NETSTANDARD2_1
        Assert.Multiple(() =>
        {
            Assert.That(error.Value.ErrorType, Is.EqualTo(expected.Value.ErrorType));
            Assert.That(error.Value.ErrorCode, Is.EqualTo(expected.Value.ErrorCode));
            Assert.That(error.Value.ErrorDescription, Is.EqualTo(expected.Value.ErrorDescription));
        });
#else
        if (!error.Value.ErrorType.Equals(expected.Value.ErrorType))
        {
            throw new SondorAssertionException(
                $"Expected error type '{expected.Value.ErrorType}', but got '{error.Value.ErrorType}'.");
        }

        if (!error.Value.ErrorCode.Equals(expected.Value.ErrorCode))
        {
            throw new SondorAssertionException(
                $"Expected error type '{expected.Value.ErrorCode}', but got '{error.Value.ErrorCode}'.");
        }

        if (!error.Value.ErrorDescription.Equals(expected.Value.ErrorDescription))
        {
            throw new SondorAssertionException(
                $"Expected error type '{expected.Value.ErrorDescription}', but got '{error.Value.ErrorDescription}'.");
        }
#endif
    }

    /// <summary>
    /// Asserts that <paramref name="result"/> matches the provided <paramref name="expected"/>.
    /// </summary>
    /// <param name="result">The error.</param>
    /// <param name="expected">The expected.</param>
    public static void AssertResult(SondorResult? result, SondorResult? expected)
    {
        if (result is null && expected is null)
        {
            return;
        }

        if (result is null && expected is not null)
        {
#if !NETSTANDARD2_0 && !NETSTANDARD2_1
            Assert.Fail("Received result is null, but was not expected to be.");

            return;
#else
            throw new SondorAssertionException("Received result is null, but was not expected to be.");
#endif
        }

        if (result is not null && expected is null)
        {
#if !NETSTANDARD2_0 && !NETSTANDARD2_1
            Assert.Fail("Received result is not null, but was expected to be.");

            return;
#else
            throw new SondorAssertionException("Received result is not null, but was expected to be.");
#endif
        }

        if (result is null || expected is null)
        {
            return;
        }

#if !NETSTANDARD2_0 && !NETSTANDARD2_1
        Assert.Multiple(() =>
        {
            Assert.That(result.Value.IsValid, Is.EqualTo(expected.Value.IsValid));
            AssertError(result.Value.Error, expected.Value.Error);
        });
#else
        if (!result.Value.IsValid.Equals(expected.Value.IsValid))
        {
            throw new SondorAssertionException(
                $"Expected result validity '{expected.Value.IsValid}', but got '{result.Value.IsValid}'.");
        }

        AssertError(result.Value.Error, expected.Value.Error);
#endif
    }

    /// <summary>
    /// Asserts that <paramref name="result"/> matches the provided <paramref name="expected"/>.
    /// </summary>
    /// <typeparam name="TResult">The result type.</typeparam>
    /// <param name="result">The error.</param>
    /// <param name="expected">The expected.</param>
    /// <param name="resultComparison">The result comparison action.</param>
    public static void AssertResult<TResult>(SondorResult<TResult>? result,
        SondorResult<TResult>? expected,
        Action<TResult?, TResult?>? resultComparison = null)
    {
        if (result is null && expected is null)
        {
            return;
        }

        if (result is null && expected is not null)
        {
#if !NETSTANDARD2_0 && !NETSTANDARD2_1
            Assert.Fail("Received result is null, but was not expected to be.");

            return;
#else
            throw new SondorAssertionException("Received result is null, but was not expected to be.");
#endif
        }

        if (result is not null && expected is null)
        {
#if !NETSTANDARD2_0 && !NETSTANDARD2_1
            Assert.Fail("Received result is not null, but was expected to be.");

            return;
#else
            throw new SondorAssertionException("Received result is not null, but was expected to be.");
#endif
        }

        if (result is null || expected is null)
        {
            return;
        }

#if !NETSTANDARD2_0 && !NETSTANDARD2_1
        Assert.Multiple(() =>
        {
            Assert.That(result.Value.IsValid, Is.EqualTo(expected.Value.IsValid));
            AssertError(result.Value.Error, expected.Value.Error);

            if (resultComparison is null)
            {
                Assert.That(result.Value.Result, Is.EqualTo(expected.Value.Result));
                return;
            }

            resultComparison(result.Value.Result, expected.Value.Result);
        });
#else
        if (!result.Value.IsValid.Equals(expected.Value.IsValid))
        {
            throw new SondorAssertionException(
                $"Expected result validity '{expected.Value.IsValid}', but got '{result.Value.IsValid}'.");
        }

        AssertError(result.Value.Error, expected.Value.Error);
#endif
    }
}