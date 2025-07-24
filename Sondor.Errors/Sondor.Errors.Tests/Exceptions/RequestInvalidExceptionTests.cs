using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="RequestInvalidException"/>.
/// </summary>
[TestFixture]
public class RequestInvalidExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="RequestInvalidException"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string message = "The request is invalid.";
        
        // act
        var exception = new RequestInvalidException(message);

        // assert
        using (Assert.EnterMultipleScope())
        {
            Assert.That(exception.Message, Is.EqualTo(message));
            Assert.That(exception, Is.InstanceOf<RequestInvalidException>());
        }
    }
}
