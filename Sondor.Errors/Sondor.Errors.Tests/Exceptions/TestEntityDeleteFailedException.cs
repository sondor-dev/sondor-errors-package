using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Test <see cref="EntityDeleteFailedException"/> exception.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="TestEntityDeleteFailedException"/>.
/// </remarks>
/// <param name="message">The message.</param>
internal sealed class TestEntityDeleteFailedException(string message) :
    EntityDeleteFailedException(message);