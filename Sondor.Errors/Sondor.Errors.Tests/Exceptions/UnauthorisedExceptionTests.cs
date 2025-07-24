using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="UnauthorisedException"/>.
/// </summary>
[TestFixture]
public class UnauthorisedExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="UnauthorisedException"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string message = "Access to this resource is unauthorized.";
        
        // act
        var exception = new UnauthorisedException(message);
        
        // assert
        using (Assert.EnterMultipleScope())
        {
            Assert.That(exception.Message, Is.EqualTo(message));
            Assert.That(exception, Is.InstanceOf<UnauthorisedException>());
        }
    }
}
