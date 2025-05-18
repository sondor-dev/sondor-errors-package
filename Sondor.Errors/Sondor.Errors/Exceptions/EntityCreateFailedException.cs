namespace Sondor.Errors.Exceptions;

/// <summary>
/// The base entity create failed exception.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="EntityCreateFailedException"/>.
/// </remarks>
/// <param name="message">The message.</param>
public abstract class EntityCreateFailedException(string message) :
    Exception(message);