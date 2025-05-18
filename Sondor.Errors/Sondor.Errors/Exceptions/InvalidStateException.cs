namespace Sondor.Errors.Exceptions;

/// <summary>
/// Invalid state exception base class.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="InvalidStateException"/>.
/// </remarks>
public abstract class InvalidStateException(string message) :
    Exception(message);