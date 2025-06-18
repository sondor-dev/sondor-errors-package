namespace Sondor.Errors;

/// <summary>
/// Collection of error messages.
/// </summary>
internal static class SondorErrorMessages
{
    /// <summary>
    /// The bad request error message.
    /// </summary>
    internal const string BadRequest =
        "Unfortunately, '{0}' validations failed.";

    /// <summary>
    /// The forbidden error message.
    /// </summary>
    internal const string Forbidden =
        "Unfortunately, you do not have permission to access the request resource";

    /// <summary>
    /// The resource already exists.
    /// </summary>
    internal const string ResourceAlreadyExists =
        "Unfortunately, an '{0}' with an '{1}' of '{2}' already exists.";

    /// <summary>
    /// The resource create failed.
    /// </summary>
    internal const string ResourceCreateFailed =
        "Unfortunately, the create '{0}' request failed.";

    /// <summary>
    /// The resource delete failed.
    /// </summary>
    internal const string ResourceDeleteFailed =
        "Unfortunately, the delete '{0}' request failed.";

    /// <summary>
    /// The resource not found error messages.
    /// </summary>
    internal const string ResourceNotFound =
        "Unfortunately, an '{0}' with an '{1}' of '{2}' was not found.";

    /// <summary>
    /// The resource patch failed.
    /// </summary>
    internal const string ResourcePatchFailed =
        "Unfortunately, the patch request failed.";

    /// <summary>
    /// The resource update failed.
    /// </summary>
    internal const string ResourceUpdateFailed =
        "Unfortunately, the update '{0}' request failed.";

    /// <summary>
    /// The unauthorized error message.
    /// </summary>
    internal const string Unauthorized =
        "Unfortunately, you're not authorized to access the requested resource.";

    /// <summary>
    /// The unexpected error.
    /// </summary>
    internal const string UnexpectedError =
        "{0}";
}
