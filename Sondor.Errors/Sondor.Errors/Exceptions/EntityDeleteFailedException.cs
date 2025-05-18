namespace Sondor.Errors.Exceptions;

/// <summary>
/// The entity delete failed exception base class.
/// </summary>
/// <param name="message">The message.</param>
public abstract class EntityDeleteFailedException(string message) :
    Exception(message);