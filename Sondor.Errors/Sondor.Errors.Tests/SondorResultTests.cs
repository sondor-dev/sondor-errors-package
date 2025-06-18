using System.Text.Json;

namespace Sondor.Errors.Tests;

/// <summary>
/// Tests for <see cref="SondorResult"/>.
/// </summary>
[TestFixture]
public class SondorResultTests
{
    /// <summary>
    /// The JSON serializer options.
    /// </summary>
    private readonly JsonSerializerOptions _options =
            new()
            {
                WriteIndented = true
            };

    /// <summary>
    /// Ensures that <see cref="SondorResult"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);

        // act
        var result = new SondorResult(error);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Error, Is.EqualTo(error));
            Assert.That(result.IsValid, Is.False);
        });
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult"/> implict cast works as expected.
    /// </summary>
    [Test]
    public void ImplicitCast()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        const bool expected = false;
        var result = new SondorResult(error);

        // act
        bool actual = result;

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult"/> explicit cast works as expected.
    /// </summary>
    [Test]
    public void ExplicitCast()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        var expected = new SondorResult(error);

        // act
        var result = (SondorResult)error;

        // assert
        SondorErrorAssert.AssertResult(result, expected);
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult{TResult}"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor_typed()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);

        // act
        var result = new SondorResult<int>(error);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Error, Is.EqualTo(error));
            Assert.That(result.IsValid, Is.False);
        });
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult{TResult}"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor_typed_result()
    {
        // arrange
        const int value = 50;

        // act
        var result = new SondorResult<int>(value);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Result, Is.EqualTo(value));
            Assert.That(result.IsValid, Is.True);
        });
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult{TResult}"/> implict cast works as expected.
    /// </summary>
    [Test]
    public void ImplicitCast_typed()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        const bool expected = false;
        var result = new SondorResult<int>(error);

        // act
        bool actual = result;

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult{TResult}"/> implict cast works as expected.
    /// </summary>
    [Test]
    public void ImplicitCast_typed_to_none_typed()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        var result = new SondorResult<int>(error);
        var expected = new SondorResult(error);

        // act
        SondorResult actual = result;

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult{TResult}"/> explicit cast works as expected.
    /// </summary>
    [Test]
    public void ExplicitCast_typed()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        var expected = new SondorResult<int>(error);

        // act
        var result = (SondorResult<int>)error;

        // assert
        SondorErrorAssert.AssertResult<int>(result, expected);
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult"/> can be serialized.
    /// </summary>
    [Test]
    public void Serialize()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        var result = new SondorResult(error);
        const string expected = """
                                {
                                  "Error": {
                                    "ErrorCode": 1000,
                                    "ErrorType": "UNEXPECTED_ERROR",
                                    "ErrorDescription": "test",
                                    "Context": {}
                                  },
                                  "IsValid": false
                                }
                                """;

        // act
        var json = JsonSerializer.Serialize(result, _options);

        // assert
        Assert.That(json, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult{TResult}"/> can be serialized.
    /// </summary>
    [Test]
    public void Serialize_typed()
    {
        // arrange
        const int value = 10;
        var result = new SondorResult<int>(value);
        const string expected = """
                                {
                                  "Result": 10,
                                  "Error": null,
                                  "IsValid": true
                                }
                                """;

        // act
        var json = JsonSerializer.Serialize(result, _options);

        // assert
        Assert.That(json, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult"/> can be deserialized.
    /// </summary>
    [Test]
    public void Deserialize()
    {
        // arrange
        var description = string.Format(SondorErrorMessages.UnexpectedError, "test");
        var error = new SondorError(SondorErrorCodes.UnexpectedError,
            SondorErrorTypes.UnexpectedErrorType,
            description);
        var expected = new SondorResult(error);
        const string json = """
                                {
                                  "Error": {
                                    "ErrorCode": 1000,
                                    "ErrorType": "UNEXPECTED_ERROR",
                                    "ErrorDescription": "test"
                                  }
                                }
                                """;

        // act
        var result = JsonSerializer.Deserialize<SondorResult>(json);

        // assert
        SondorErrorAssert.AssertResult(result, expected);
    }

    /// <summary>
    /// Ensures that <see cref="SondorResult{TResult}"/> can be deserialized.
    /// </summary>
    [Test]
    public void Deserialize_typed()
    {
        // arrange
        const int value = 10;
        var expected = new SondorResult<int>(value);
        const string json = """
                            {
                              "Result": 10
                            }
                            """;

        // act
        var result = JsonSerializer.Deserialize<SondorResult<int>>(json);

        // assert
        SondorErrorAssert.AssertResult<int>(result, expected);
    }
}