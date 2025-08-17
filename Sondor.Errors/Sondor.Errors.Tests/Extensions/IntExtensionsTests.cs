using Sondor.Errors.Exceptions;
using Sondor.Errors.Extensions;
using Sondor.Errors.Tests.Args;

namespace Sondor.Errors.Tests.Extensions;

/// <summary>
/// Tests for the <see cref="IntExtensions"/> class.
/// </summary>
[TestFixture]
public class IntExtensionsTests
{
    /// <summary>
    /// Ensures that the <see cref="IntExtensions.ToEnum{TEnum}"/> method returns the correct translation for the given error code.
    /// </summary>
    /// <param name="errorCode">The error code.</param>
    /// <exception cref="UnsupportedErrorCodeException">This exception is thrown when an unsupported error code is encountered.</exception>
    [TestCaseSource(typeof(SondorErrorCodeArgs))]
    public void ToEnum(int errorCode)
    {
        // arrange
        if (!new[]
            {
                SondorErrorCodes.BadRequest,
                SondorErrorCodes.ResourceNotFound
            }.Contains(errorCode))
        {
            Assert.Throws<UnsupportedErrorCodeException>(() => errorCode.ToEnum<TestEnum>());

            return;
        }

#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
        var expectedTranslation = errorCode switch
#pragma warning restore CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
        {
            SondorErrorCodes.BadRequest => TestEnum.Value1,
            SondorErrorCodes.ResourceNotFound => TestEnum.Value2
        };

        // act
        var actualTranslation = errorCode.ToEnum<TestEnum>();

        // assert
        Assert.That(actualTranslation, Is.EqualTo(expectedTranslation), $"Expected translation for error code {errorCode} to be {expectedTranslation}, but got {actualTranslation}.");
    }

    /// <summary>
    /// Ensures that the <see cref="IntExtensions.IsSondorErrorCode"/> method returns the correct result.
    /// </summary>
    /// <param name="errorCode">The error code.</param>
    [TestCaseSource(typeof(SondorErrorCodeArgs))]
    public void IsSondorErrorCode(int errorCode)
    {
        // act
        var actual = errorCode.IsSondorErrorCode();

        // assert
        Assert.That(actual, Is.True);
    }

    /// <summary>
    /// Ensures that the <see cref="IntExtensions.IsSondorErrorCode"/> method returns the correct result.
    /// </summary>
    [Test]
    public void IsSondorErrorCode_False()
    {
        // act
        var actual = int.MinValue.IsSondorErrorCode();

        // assert
        Assert.That(actual, Is.False);
    }
}
