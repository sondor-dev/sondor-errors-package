namespace Sondor.Errors;

/// <summary>
/// Collection of error messages.
/// </summary>
public static class SondorErrorMessages
{
    /// <summary>
    /// The bad request error message.
    /// </summary>
    public const string BadRequest =
        "Unfortunately, '{0}' validations failed.";

    /// <summary>
    /// The forbidden error message.
    /// </summary>
    public const string Forbidden =
        "Unfortunately, you do not have permission to access the request resource";

    /// <summary>
    /// The resource already exists.
    /// </summary>
    public const string ResourceAlreadyExists =
        "Unfortunately, an '{0}' with an '{1}' of '{2}' already exists.";

    /// <summary>
    /// The resource create failed.
    /// </summary>
    public const string ResourceCreateFailed =
        "Unfortunately, the create '{0}' request failed.";

    /// <summary>
    /// The resource delete failed.
    /// </summary>
    public const string ResourceDeleteFailed =
        "Unfortunately, the delete '{0}' request failed.";

    /// <summary>
    /// The resource not found error messages.
    /// </summary>
    public const string ResourceNotFound =
        "Unfortunately, an '{0}' with an '{1}' of '{2}' was not found.";

    /// <summary>
    /// The resource patch failed.
    /// </summary>
    public const string ResourcePatchFailed =
        "Unfortunately, the patch request failed.";

    /// <summary>
    /// The resource update failed.
    /// </summary>
    public const string ResourceUpdateFailed =
        "Unfortunately, the update '{0}' request failed.";

    /// <summary>
    /// The unauthorized error message.
    /// </summary>
    public const string Unauthorized =
        "Unfortunately, you're not authorized to access the requested resource.";

    /// <summary>
    /// The unexpected error.
    /// </summary>
    public const string UnexpectedError =
        "{0}";
}
