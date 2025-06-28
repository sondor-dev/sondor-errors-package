using Sondor.Errors.Constants;

namespace Sondor.Errors.Exceptions;

/// <summary>
/// Resource create failed exception.
/// </summary>
public class ResourceCreateFailedException :
    Exception
{
    /// <summary>
    /// The resource that failed to be created.
    /// </summary>
    public string Resource { get; init; }

    /// <summary>
    /// The new resource that was attempted to be created.
    /// </summary>
    public object? NewResource { get; init; }

    /// <summary>
    /// The reasons for the failure to create the resource.
    /// </summary>
    public IEnumerable<string> Reasons { get; init; }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceCreateFailedException"/>.
    /// </summary>
    /// <param name="reasons">The reasons for the failure to create the resource.</param>
    /// <param name="resource">The resource that failed to be created.</param>
    /// <param name="newResource">The new resource that was attempted to be created.</param>
    public ResourceCreateFailedException(string resource,
        object? newResource = default,
        IEnumerable<string>? reasons = null) :
        base(string.Format(ExceptionConstants.ResourceCreateFailedMessage, resource))
    {
        Resource = resource;
        Reasons = reasons ?? [];
        NewResource = newResource;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceCreateFailedException"/>.
    /// </summary>
    /// <param name="reasons">The reasons for the failure to create the resource.</param>
    /// <param name="resource">The resource that failed to be created.</param>
    /// <param name="newResource">The new resource that was attempted to be created.</param>
    /// <param name="messageFormat">The message format.</param>
    public ResourceCreateFailedException(string messageFormat,
        string resource,
        object? newResource = default,
        IEnumerable<string>? reasons = null) :
        base(string.Format(messageFormat, resource))
    {
        Resource = resource;
        Reasons = reasons ?? [];
        NewResource = newResource;
    }
}