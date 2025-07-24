using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="UnsupportedException"/>.
/// </summary>
[TestFixture]
public class UnsupportedExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="UnsupportedException"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string message = "This operation is not supported.";
        
        // act
        var exception = new UnsupportedException(message);
        
        // assert
        using (Assert.EnterMultipleScope())
        {
            Assert.That(exception.Message, Is.EqualTo(message));
            Assert.That(exception, Is.InstanceOf<UnsupportedException>());
        }
    }
}