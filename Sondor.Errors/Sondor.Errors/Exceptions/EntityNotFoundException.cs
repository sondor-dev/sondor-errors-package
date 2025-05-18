namespace Sondor.Errors.Exceptions;

/// <summary>
/// Entity not found exception base class.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="EntityNotFoundException"/>.
/// </remarks>
/// <param name="message">The error message.</param>
public abstract class EntityNotFoundException(string message) :
    Exception(message);