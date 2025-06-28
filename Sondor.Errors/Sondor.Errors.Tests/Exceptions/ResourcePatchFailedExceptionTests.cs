using Sondor.Errors.Constants;
using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="ResourcePatchFailedException"/>.
/// </summary>
[TestFixture]
public class ResourcePatchFailedExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="ResourcePatchFailedException"/> constructor sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string resource = "TestResource";
        var patches = new Dictionary<string, string?>
        {
            { "Patch1", "Value1" },
            { "Patch2", null }
        };
        var expected = string.Format(ExceptionConstants.ResourcePatchFailedMessage, resource);

        // act
        var exception = new ResourcePatchFailedException(resource, patches);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Resource, Is.EqualTo(resource));
            Assert.That(exception.Patches, Is.EqualTo(patches));
            Assert.That(exception.Message, Is.EqualTo(expected));
        });
    }

    /// <summary>
    /// Ensures that <see cref="ResourcePatchFailedException"/> constructor with override message format sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor_override_message()
    {
        // arrange
        const string resource = "TestResource";
        var patches = new Dictionary<string, string?>
        {
            { "Patch1", "Value1" },
            { "Patch2", null }
        };
        const string messageFormat = "Custom message format for {0}";
        var expected = string.Format(messageFormat, resource);

        // act
        var exception = new ResourcePatchFailedException(messageFormat, resource, patches);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Resource, Is.EqualTo(resource));
            Assert.That(exception.Patches, Is.EqualTo(patches));
            Assert.That(exception.Message, Is.EqualTo(expected));
        });
    }
}
