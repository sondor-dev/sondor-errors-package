using Sondor.Errors.Constants;

namespace Sondor.Errors.Exceptions;

/// <summary>
/// Resource not found exception.
/// </summary>
public class ResourceNotFoundException :
    Exception
{
    /// <summary>
    /// The resource that was not found.
    /// </summary>
    public string Resource { get; } = string.Empty;

    /// <summary>
    /// The name of the property that was used to search for the resource.
    /// </summary>
    public string PropertyName { get; } = string.Empty;

    /// <summary>
    /// The value of the property that was used to search for the resource.
    /// </summary>
    public string? PropertyValue { get; }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceNotFoundException"/>.
    /// </summary>
    /// <param name="resource">The resource that was not found.</param>
    /// <param name="propertyName">The name of the property that was used to search for the resource.</param>
    /// <param name="propertyValue">The value of the property that was used to search for the resource.</param>
    public ResourceNotFoundException(string resource,
        string propertyName,
        string? propertyValue) :
        base(string.Format(ExceptionConstants.ResourceNotFoundExceptionMessage, resource, propertyName, propertyValue))
    {
        Resource = resource;
        PropertyName = propertyName;
        PropertyValue = propertyValue;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceNotFoundException"/>.
    /// </summary>
    /// <param name="messageFormat">The message format.</param>
    /// <param name="resource">The resource that was not found.</param>
    /// <param name="propertyName">The name of the property that was used to search for the resource.</param>
    /// <param name="propertyValue">The value of the property that was used to search for the resource.</param>
    public ResourceNotFoundException(string messageFormat,
        string resource,
        string propertyName,
        string? propertyValue) :
        base(string.Format(messageFormat, resource, propertyName, propertyValue))
    {
        Resource = resource;
        PropertyName = propertyName;
        PropertyValue = propertyValue;
    }

    /// <summary>
    /// Create a new instance of the <see cref="ResourceNotFoundException"/> with a custom message.
    /// </summary>
    /// <param name="message">The message.</param>
    public ResourceNotFoundException(string message) : 
        base(message)
    {
    }
}