using Sondor.Errors.Attributes;

namespace Sondor.Errors.Tests.Attributes;

/// <summary>
/// Tests for <see cref="SondorErrorCodeAttribute"/>.
/// </summary>
[TestFixture]
public class SondorErrorCodeAttributeTests
{
    /// <summary>
    /// Ensures the <see cref="SondorErrorCodeAttribute"/> constructor sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const int errorCode = 1000;

        // act
        var attribute = new SondorErrorCodeAttribute(errorCode);

        // assert
        Assert.That(attribute.ErrorCode, Is.EqualTo(errorCode));
    }
}