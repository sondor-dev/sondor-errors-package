namespace Sondor.Errors.Exceptions;

/// <summary>
/// Entity update failed exception base class.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="EntityUpdateFailedException"/>.
/// </remarks>
public abstract class EntityUpdateFailedException(string message) :
    Exception(message);
