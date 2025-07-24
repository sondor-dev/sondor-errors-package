namespace Sondor.Errors.Exceptions;

/// <summary>
/// Forbidden exception is thrown for forbidden requests.
/// </summary>
/// <remarks>
/// Create a new instance of the <see cref="ForbiddenException"/> class with a specified error message.
/// </remarks>
public class ForbiddenException(string message) :
    Exception(message);