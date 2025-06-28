using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="SondorAssertionException"/>.
/// </summary>
[TestFixture]
public class SondorAssertionExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="SondorAssertionException"/> constructor works as expected.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // Arrange
        const string message = "This is an assertion exception";

        // Act
        var exception = new SondorAssertionException(message);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Message, Is.EqualTo(message));
            Assert.That(exception, Is.InstanceOf<SondorAssertionException>());
            Assert.That(exception, Is.InstanceOf<Exception>());
        });
    }
}
