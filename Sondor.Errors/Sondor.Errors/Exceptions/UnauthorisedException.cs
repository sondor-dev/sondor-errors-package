namespace Sondor.Errors.Exceptions;

/// <summary>
/// Unauthorised exception is thrown for unauthorised requests.
/// </summary>
/// <remarks>
/// Creates a new instance of the <see cref="UnauthorisedException"/> class with a specified error message.
/// </remarks>
public class UnauthorisedException(string message) :
    Exception(message);