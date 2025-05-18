using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests <see cref="EntityCreateFailedException"/> exception.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="EntityCreateFailedException"/>.
/// </remarks>
/// <param name="message">The message.</param>
internal sealed class TestEntityCreateFailedException(string message) :
    EntityCreateFailedException(message);