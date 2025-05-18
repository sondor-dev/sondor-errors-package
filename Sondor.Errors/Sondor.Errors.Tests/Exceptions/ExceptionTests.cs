using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for exceptions.
/// </summary>
[TestFixture]
public class ExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="EntityCreateFailedException"/> works as expected.
    /// </summary>
    [Test]
    public void EntityCreateFailedExceptionConstructor()
    {
        // arrange
        const string expected = "Test message.";

        // act
        var exception = new TestEntityCreateFailedException(expected);

        // assert
        Assert.That(exception.Message, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="EntityDeleteFailedException"/> works as expected.
    /// </summary>
    [Test]
    public void EntityDeleteFailedExceptionConstructor()
    {
        // arrange
        const string expected = "Test message.";

        // act
        var exception = new TestEntityDeleteFailedException(expected);

        // assert
        Assert.That(exception.Message, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="EntityNotFoundException"/> works as expected.
    /// </summary>
    [Test]
    public void EntityNotFoundExceptionConstructor()
    {
        // arrange
        const string expected = "Test message.";

        // act
        var exception = new TestEntityNotFoundException(expected);

        // assert
        Assert.That(exception.Message, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="EntityUpdateFailedException"/> works as expected.
    /// </summary>
    [Test]
    public void EntityUpdateFailedExceptionConstructor()
    {
        // arrange
        const string expected = "Test message.";

        // act
        var exception = new TestEntityUpdateFailedException(expected);

        // assert
        Assert.That(exception.Message, Is.EqualTo(expected));
    }

    /// <summary>
    /// Ensures that <see cref="InvalidStateException"/> works as expected.
    /// </summary>
    [Test]
    public void InvalidStateExceptionConstructor()
    {
        // arrange
        const string expected = "Test message.";

        // act
        var exception = new TestInvalidStateException(expected);

        // assert
        Assert.That(exception.Message, Is.EqualTo(expected));
    }
}
