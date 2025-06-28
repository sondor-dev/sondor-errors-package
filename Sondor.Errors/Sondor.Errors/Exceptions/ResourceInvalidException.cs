namespace Sondor.Errors.Exceptions;

/// <summary>
/// Resource invalid exception.
/// </summary>
public class ResourceInvalidException :
    Exception
{
    /// <summary>
    /// Create a new instance of the <see cref="ResourceInvalidException"/> with a custom message.
    /// </summary>
    /// <param name="message">The message.</param>
    public ResourceInvalidException(string message) :
        base(message)
    {
    }
}
