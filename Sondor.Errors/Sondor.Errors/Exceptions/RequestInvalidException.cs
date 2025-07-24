namespace Sondor.Errors.Exceptions;

/// <summary>
/// Request Invalid exception is thrown for invalid requests.
/// </summary>
/// <remarks>
/// Create a new instance of the <see cref="RequestInvalidException"/> class with a specified error message.
/// </remarks>
/// <param name="message">The error message.</param>
public class RequestInvalidException(string message) :
    Exception(message);