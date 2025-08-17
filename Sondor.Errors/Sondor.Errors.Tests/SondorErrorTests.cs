using System.Text.Json;
using Sondor.Tests.Args;

namespace Sondor.Errors.Tests;

/// <summary>
/// Tests for <see cref="SondorError"/>.
/// </summary>
[TestFixture]
public class SondorErrorTests
{
    /// <summary>
    /// The options.
    /// </summary>
    private readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true
    };

    /// <summary>
    /// Ensures that <see cref="SondorError"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const int errorCode = 101;
        const string errorType = "test-error-type";
        const string errorDescription = "test-error-description";

        // act
        var error = new SondorError(errorCode, errorType, errorDescription);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(error.ErrorCode, Is.EqualTo(errorCode));
            Assert.That(error.ErrorType, Is.EqualTo(errorType));
            Assert.That(error.ErrorDescription, Is.EqualTo(errorDescription));
        });
    }

    /// <summary>
    /// Ensures that <see cref="SondorError"/> can be serialized.
    /// </summary>
    [Test]
    public void Serialize()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        const string expected = """
                                {
                                  "ErrorCode": 1000,
                                  "ErrorType": "UNEXPECTED_ERROR",
                                  "ErrorDescription": "test",
                                  "Context": {}
                                }
                                """;

        // act
        var json = JsonSerializer.Serialize(error, _options);

        // assert
        Assert.That(json, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorError"/> can be deserialized.
    /// </summary>
    [Test]
    public void Deserialize()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var expected = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        const string json = """
                                {
                                  "ErrorCode": 1000,
                                  "ErrorType": "UNEXPECTED_ERROR",
                                  "ErrorDescription": "test"
                                }
                                """;

        // act
        var error = JsonSerializer.Deserialize<SondorError>(json);

        // assert
        SondorErrorAssert.AssertError(error, expected);
    }

    /// <summary>
    /// Ensures that <see cref="SondorError.Equals(object?)"/> works as expected.
    /// </summary>
    [TestCaseSource(typeof(BoolArgs))]
    public void Equals(bool expected)
    {
        // arrange
        const int errorCode = 101;
        const string errorType = "test-error-type";
        const string errorDescription = "test-error-description";
        var error2ErrorCode = expected ? errorCode : -1;
        var error = new SondorError(errorCode, errorType, errorDescription);
        var error1 = new SondorError(error2ErrorCode, errorType, errorDescription);

        // act
        var equals = error.Equals(error1);

        // assert
        Assert.That(equals, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorError.Equals(object?)"/> works as expected.
    /// </summary>
    [TestCaseSource(typeof(BoolArgs))]
    public void EqualsObject(bool expected)
    {
        // arrange
        const int errorCode = 101;
        const string errorType = "test-error-type";
        const string errorDescription = "test-error-description";
        var error2ErrorCode = expected ? errorCode : -1;
        var error = new SondorError(errorCode, errorType, errorDescription);
        object error1 = new SondorError(error2ErrorCode, errorType, errorDescription);

        // act
        var equals = error.Equals(error1);

        // assert
        Assert.That(equals, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorError.Equals(object?)"/> works as expected.
    /// </summary>
    [Test]
    public void EqualsWrongType()
    {
        // arrange
        const int errorCode = 101;
        const string errorType = "test-error-type";
        const string errorDescription = "test-error-description";
        var error = new SondorError(errorCode, errorType, errorDescription);

        // act
        // ReSharper disable once SuspiciousTypeConversion.Global
        var equals = error.Equals(1);

        // assert
        Assert.That(equals, Is.False);
    }

    /// <summary>
    /// Ensures that <see cref="SondorError.op_Equality"/> works as expected.
    /// </summary>
    [TestCaseSource(typeof(BoolArgs))]
    public void EqualsOperator(bool expected)
    {
        // arrange
        const int errorCode = 101;
        const string errorType = "test-error-type";
        const string errorDescription = "test-error-description";
        var error2ErrorCode = expected ? errorCode : -1;
        var error = new SondorError(errorCode, errorType, errorDescription);
        var error1 = new SondorError(error2ErrorCode, errorType, errorDescription);

        // act
        var equals = error == error1;

        // assert
        Assert.That(equals, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorError.op_Inequality"/> works as expected.
    /// </summary>
    [TestCaseSource(typeof(BoolArgs))]
    public void DoesNotEqualsOperator(bool expected)
    {
        // arrange
        const int errorCode = 101;
        const string errorType = "test-error-type";
        const string errorDescription = "test-error-description";
        var error2ErrorCode = expected ? errorCode : -1;
        var error = new SondorError(errorCode, errorType, errorDescription);
        var error1 = new SondorError(error2ErrorCode, errorType, errorDescription);

        // act
        var equals = error != error1;

        // assert
        Assert.That(equals, Is.EqualTo(!expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorError.GetHashCode"/> works as expected.
    /// </summary>
    [Test]
    public void ErrorGetHashCode()
    {
        // arrange
        const int errorCode = 101;
        const string errorType = "test-error-type";
        const string errorDescription = "test-error-description";
        var error = new SondorError(errorCode, errorType, errorDescription);

#if NETSTANDAR2_1 || NETCOREAPP
        var expected = HashCode.Combine(errorCode, errorType, errorDescription);
#else
        // .NET Standard 2.0 does not support HashCode.Combine
        // Use a custom hash code calculation
        var hash = 17;
        
        hash = hash * 31 + errorCode.GetHashCode();
        hash = hash * 31 + errorType.GetHashCode();
        hash = hash * 31 + errorDescription.GetHashCode();
        
        var expected = hash;
#endif

        // act
        var hashCode = error.GetHashCode();

        // assert
        Assert.That(hashCode, Is.EqualTo(expected));
    }
}