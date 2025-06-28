using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="ResourceInvalidException"/>.
/// </summary>
[TestFixture]
public class ResourceInvalidExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="ResourceInvalidException"/> constructor initializes the message correctly.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string message = "This is a custom message";
        
        // act
        var exception = new ResourceInvalidException(message);
        
        // assert
        Assert.That(exception.Message, Is.EqualTo(message));
    }
}
