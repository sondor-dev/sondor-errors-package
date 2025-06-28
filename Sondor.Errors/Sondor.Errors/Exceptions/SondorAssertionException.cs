namespace Sondor.Errors.Exceptions;

/// <summary>
/// The assertion exception.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="SondorAssertionException"/>.
/// </remarks>
/// <param name="message">The message.</param>
public class SondorAssertionException(string message) :
    Exception(message);