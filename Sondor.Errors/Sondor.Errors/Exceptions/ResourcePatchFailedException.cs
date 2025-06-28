using Sondor.Errors.Constants;

namespace Sondor.Errors.Exceptions;

/// <summary>
/// Resource patch failed exception.
/// </summary>
public class ResourcePatchFailedException :
    Exception
{
    /// <summary>
    /// The resource that failed to patch.
    /// </summary>
    public string Resource { get; }

    /// <summary>
    /// The patches that failed to apply.
    /// </summary>
    public IDictionary<string, string?> Patches { get; }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourcePatchFailedException"/>.
    /// </summary>
    /// <param name="resource">The resource that failed to patch.</param>
    /// <param name="patches">The patches that failed to apply.</param>
    public ResourcePatchFailedException(string resource,
        IDictionary<string, string?> patches) :
        base(string.Format(ExceptionConstants.ResourcePatchFailedMessage, resource))
    {
        Resource = resource;
        Patches = patches;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ResourcePatchFailedException"/>.
    /// </summary>
    /// <param name="resource">The resource that failed to patch.</param>
    /// <param name="patches">The patches that failed to apply.</param>
    /// <param name="messageFormat">The message format.</param>
    public ResourcePatchFailedException(string messageFormat,
        string resource,
        IDictionary<string, string?> patches) :
        base(string.Format(messageFormat, resource))
    {
        Resource = resource;
        Patches = patches;
    }
}
