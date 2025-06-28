using Sondor.Errors.Constants;
using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="ResourceDeleteFailedException"/>.
/// </summary>
[TestFixture]
public class ResourceDeleteFailedExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="ResourceDeleteFailedException"/> constructor with resource, property name, and property value sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string resource = "TestResource";
        var reasons = new[] { "Reason1", "Reason2" };
        var expected = string.Format(ExceptionConstants.ResourceDeleteFailedMessage, resource);

        // act
        var exception = new ResourceDeleteFailedException(resource, reasons);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Resource, Is.EqualTo(resource));
            Assert.That(exception.Message, Is.EqualTo(expected));
            Assert.That(exception.Reasons, Is.EqualTo(reasons));
        });
    }

    /// <summary>
    /// Ensures that <see cref="ResourceDeleteFailedException"/> constructor with resource, property name, and property value sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor_override_message()
    {
        // arrange
        const string resource = "TestResource";
        const string messageFormat = "Custom message format for {0}";
        var reasons = new[] { "Reason1", "Reason2" };
        var expected = string.Format(messageFormat, resource);

        // act
        var exception = new ResourceDeleteFailedException(messageFormat, resource, reasons);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Resource, Is.EqualTo(resource));
            Assert.That(exception.Message, Is.EqualTo(expected));
            Assert.That(exception.Reasons, Is.EqualTo(reasons));
        });
    }
}
