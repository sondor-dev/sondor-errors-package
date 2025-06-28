using Sondor.Errors.Constants;

namespace Sondor.Errors.Exceptions;

/// <summary>
/// Resource update failed exception.
/// </summary>
public class ResourceUpdateFailedException :
    Exception
{
    /// <summary>
    /// The resource that failed to be updated.
    /// </summary>
    public string Resource { get; }

    /// <summary>
    /// The new resource that was attempted to be updated.
    /// </summary>
    public object? NewResource { get; }

    /// <summary>
    /// The reasons for the failure to create the resource.
    /// </summary>
    public IEnumerable<string> Reasons { get; }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceCreateFailedException"/>.
    /// </summary>
    /// <param name="reasons">The reasons for the failure to update the resource.</param>
    /// <param name="resource">The resource that failed to be updated.</param>
    /// <param name="newResource">The new resource that was attempted to be updated.</param>
    public ResourceUpdateFailedException(string resource,
        object? newResource = default,
        IEnumerable<string>? reasons = null) :
        base(string.Format(ExceptionConstants.ResourceUpdateFailedMessage, resource))
    {
        Resource = resource;
        Reasons = reasons ?? [];
        NewResource = newResource;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceCreateFailedException"/>.
    /// </summary>
    /// <param name="reasons">The reasons for the failure to update the resource.</param>
    /// <param name="resource">The resource that failed to be updated.</param>
    /// <param name="newResource">The new resource that was attempted to be updated.</param>
    /// <param name="messageFormat">The message format.</param>
    public ResourceUpdateFailedException(string messageFormat,
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