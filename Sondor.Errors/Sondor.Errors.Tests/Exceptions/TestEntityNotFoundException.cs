using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for <see cref="EntityNotFoundException"/>.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="TestEntityNotFoundException"/>.
/// </remarks>
/// <param name="message">The message.</param>
internal sealed class TestEntityNotFoundException(string message) :
    EntityNotFoundException(message);