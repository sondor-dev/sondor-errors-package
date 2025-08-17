using Sondor.Errors.Extensions;

namespace Sondor.Errors.Tests.Extensions;

/// <summary>
/// Tests for <see cref="ObjectExtensions"/>.
/// </summary>
[TestFixture]
public class ObjectExtensionsTests
{
    /// <summary>
    /// Ensures that <see cref="ObjectExtensions.IsEmpty{TType}"/> determines if a type instance is an empty instance.
    /// </summary>
    [Test]
    public void IsEmpty()
    {
        // arrange
        var instance = new TestClass();

        // act
        var actual = instance.IsEmpty();

        // assert
        Assert.That(actual, Is.True);
    }

    /// <summary>
    /// Ensures that <see cref="ObjectExtensions.IsEmpty{TType}"/> determines if a type instance is an empty instance.
    /// </summary>
    [Test]
    public void IsEmpty_False()
    {
        // arrange
        var instance = new TestClass()
        {
            Values = ["test-1"]
        };

        // act
        var actual = instance.IsEmpty();

        // assert
        Assert.That(actual, Is.False);
    }
}