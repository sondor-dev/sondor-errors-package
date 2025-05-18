using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests <see cref="EntityUpdateFailedException"/>.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="TestEntityUpdateFailedException"/>.
/// </remarks>
/// <param name="message">The message.</param>
internal sealed class TestEntityUpdateFailedException(string message) :
    EntityUpdateFailedException(message);
