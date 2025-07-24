namespace Sondor.Errors.Exceptions;

/// <summary>
/// Unsupported exception is thrown for unsupported requests.
/// </summary>
/// <remarks>
/// Create a new instance of the <see cref="UnsupportedException"/> class with a specified error message.
/// </remarks>
public class UnsupportedException(string message) :
    Exception(message);