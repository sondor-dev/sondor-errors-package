using Sondor.Errors.Constants;
using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="ResourceUpdateFailedException"/>.
/// </summary>
[TestFixture]
public class ResourceUpdateFailedExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="ResourceUpdateFailedException"/> constructor with resource, property name, and property value sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string resource = "TestResource";
        const string newResource = "test";
        var reasons = new[] { "Reason1", "Reason2" };
        var expected = string.Format(ExceptionConstants.ResourceUpdateFailedMessage, resource);

        // act
        var exception = new ResourceUpdateFailedException(resource, newResource, reasons);

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
    /// Ensures that <see cref="ResourceUpdateFailedException"/> constructor with override message format sets properties correctly.
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
        var exception = new ResourceUpdateFailedException(messageFormat, resource, newResource, reasons);

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
