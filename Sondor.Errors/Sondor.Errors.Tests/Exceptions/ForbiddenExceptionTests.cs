using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="ForbiddenException"/>.
/// </summary>
public class ForbiddenExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="ForbiddenException"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string message = "Access to this resource is forbidden.";
        
        // act
        var exception = new ForbiddenException(message);
        
        // assert
        using (Assert.EnterMultipleScope())
        {
            Assert.That(exception.Message, Is.EqualTo(message));
            Assert.That(exception, Is.InstanceOf<ForbiddenException>());
        }
    }
}