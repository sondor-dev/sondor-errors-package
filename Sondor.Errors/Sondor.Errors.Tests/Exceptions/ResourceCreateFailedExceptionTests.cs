using Sondor.Errors.Constants;
using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="ResourceCreateFailedException"/>.
/// </summary>
[TestFixture]
public class ResourceCreateFailedExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="ResourceCreateFailedException"/> constructor with resource, property name, and property value sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string resource = "TestResource";
        const string newResource = "test";
        var reasons = new[] { "Reason1", "Reason2" };
        var expected = string.Format(ExceptionConstants.ResourceCreateFailedMessage, resource);

        // act
        var exception = new ResourceCreateFailedException(resource, newResource, reasons);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Resource, Is.EqualTo(resource));
            Assert.That(exception.Message, Is.EqualTo(expected));
            Assert.That(exception.Reasons, Is.EqualTo(reasons));
            Assert.That(exception.NewResource, Is.EqualTo(newResource));
        });
    }

    /// <summary>
    /// Ensures that <see cref="ResourceCreateFailedException"/> constructor with override message format sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor_override_message()
    {
        // arrange
        const string resource = "TestResource";
        const string newResource = "test";
        const string messageFormat = "Custom message format for {0}";
        var reasons = new[] { "Reason1", "Reason2" };
        var expected = string.Format(messageFormat, resource);

        // act
        var exception = new ResourceCreateFailedException(messageFormat, resource, newResource, reasons);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Resource, Is.EqualTo(resource));
            Assert.That(exception.Message, Is.EqualTo(expected));
            Assert.That(exception.Reasons, Is.EqualTo(reasons));
            Assert.That(exception.NewResource, Is.EqualTo(newResource));
        });
    }
}
