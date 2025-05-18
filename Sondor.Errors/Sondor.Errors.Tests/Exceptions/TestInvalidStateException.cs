using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests <see cref="InvalidStateException"/> exception.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="TestInvalidStateException"/>.
/// </remarks>
/// <param name="message">The message.</param>
internal sealed class TestInvalidStateException(string message) :
    InvalidStateException(message);