using Sondor.Errors.Constants;
using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for the <see cref="UnsupportedErrorCodeException"/> class.
/// </summary>
[TestFixture]
public class UnsupportedErrorCodeExceptionTests
{
    /// <summary>
    /// Ensures that the constructor of <see cref="UnsupportedErrorCodeException"/> works as expected.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const int errorCode = 404;
        var expected = string.Format(ExceptionConstants.UnsupportedErrorCode, errorCode);

        // act
        var exception = new UnsupportedErrorCodeException(errorCode);

        // assert
        using (Assert.EnterMultipleScope())
        {
            Assert.That(exception.Message, Is.EqualTo(expected), "Message should be initialized correctly.");
            Assert.That(exception.ErrorCode, Is.EqualTo(errorCode), "ErrorCode should be initialized correctly.");
        }
    }
}