using Sondor.Errors.Constants;

namespace Sondor.Errors.Exceptions;

/// <summary>
/// Resource already exists exception.
/// </summary>
public class ResourceAlreadyExistsException :
    Exception
{
    /// <summary>
    /// The resource that already exists.
    /// </summary>
    public string Resource { get; init; }

    /// <summary>
    /// The name of the property that was used to check for the resource.
    /// </summary>
    public string PropertyName { get; init; }
    
    /// <summary>
    /// The value of the property that was used to check for the resource.
    /// </summary>
    public string? PropertyValue { get; init; }
    
    /// <summary>
    /// Creates a new instance of the <see cref="ResourceAlreadyExistsException"/>.
    /// </summary>
    /// <param name="resource">The resource that already exists.</param>
    /// <param name="propertyName">The name of the property that was used to check for the resource.</param>
    /// <param name="propertyValue">The value of the property that was used to check for the resource.</param>
    public ResourceAlreadyExistsException(string resource,
        string propertyName,
        string? propertyValue) :
        base(string.Format(ExceptionConstants.ResourceAlreadyExistsMessage, resource, propertyName, propertyValue))
    {
        Resource = resource;
        PropertyName = propertyName;
        PropertyValue = propertyValue;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceAlreadyExistsException"/>.
    /// </summary>
    /// <param name="messageFormat">The message format.</param>
    /// <param name="resource">The resource that already exists.</param>
    /// <param name="propertyName">The name of the property that was used to check for the resource.</param>
    /// <param name="propertyValue">The value of the property that was used to check for the resource.</param>
    public ResourceAlreadyExistsException(string messageFormat,
        string resource,
        string propertyName,
        string? propertyValue) :
        base(string.Format(messageFormat, resource, propertyName, propertyValue))
    {
        Resource = resource;
        PropertyName = propertyName;
        PropertyValue = propertyValue;
    }
}