using Sondor.Errors.Constants;

namespace Sondor.Errors.Exceptions;

/// <summary>
/// Resource delete failed exception.
/// </summary>
public class ResourceDeleteFailedException :
    Exception
{
    /// <summary>
    /// The resource that failed to delete.
    /// </summary>
    public string Resource { get; init; }

    /// <summary>
    /// The reasons for the failure to delete the resource.
    /// </summary>
    public IEnumerable<string> Reasons { get; init; }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceDeleteFailedException"/>.
    /// </summary>
    /// <param name="resource">The resource that failed to delete.</param>
    /// <param name="reasons">The reasons that the deletion failed.</param>
    public ResourceDeleteFailedException(string resource,
        IEnumerable<string>? reasons = null) :
        base(string.Format(ExceptionConstants.ResourceDeleteFailedMessage, resource))
    {
        Resource = resource;
        Reasons = reasons ?? [];
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourceDeleteFailedException"/>.
    /// </summary>
    /// <param name="resource">The resource that failed to delete.</param>
    /// <param name="reasons">The reasons that the deletion failed.</param>
    /// <param name="messageFormat">The message format.</param>
    public ResourceDeleteFailedException(string messageFormat,
        string resource,
        IEnumerable<string>? reasons = null) :
        base(string.Format(messageFormat, resource))
    {
        Resource = resource;
        Reasons = reasons ?? [];
    }
}