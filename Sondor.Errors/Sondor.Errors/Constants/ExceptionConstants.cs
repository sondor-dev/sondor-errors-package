namespace Sondor.Errors.Constants;

/// <summary>
/// Collection of exception constants.
/// </summary>
internal static class ExceptionConstants
{
    /// <summary>
    /// The resource create failed exception message.
    /// </summary>
    internal const string ResourceCreateFailedMessage =
        "Unfortunately, '{0}' failed to be created.";

    /// <summary>
    /// The resource update failed exception message.
    /// </summary>
    internal const string ResourceUpdateFailedMessage =
        "Unfortunately, '{0}' failed to be updated.";

    /// <summary>
    /// The resource delete failed exception message.
    /// </summary>
    internal const string ResourceDeleteFailedMessage =
        "Unfortunately, '{0}' failed to be deleted.";

    /// <summary>
    /// The resource patch failed exception message.
    /// </summary>
    internal const string ResourcePatchFailedMessage =
        "Unfortunately, '{0}' failed to be patched.";

    /// <summary>
    /// The resource not found exception message.
    /// </summary>
    internal const string ResourceNotFoundExceptionMessage =
        "Unfortunately, '{0}' was not found with an '{1}' of '{2}'.";

    /// <summary>
    /// The resource already exists exception message.
    /// </summary>
    internal const string ResourceAlreadyExistsMessage =
        "Unfortunately, '{0}' already exists with an '{1}' of '{2}'.";
}