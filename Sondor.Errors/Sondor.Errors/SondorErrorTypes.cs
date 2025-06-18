namespace Sondor.Errors;

/// <summary>
/// Collection of Sondor error types.
/// </summary>
public class SondorErrorTypes
{
    /// <summary>
    /// The bad request type.
    /// </summary>
    public const string BadRequestType = "BAD_REQUEST";

    /// <summary>
    /// The forbidden type.
    /// </summary>
    public const string ForbiddenType = "FORBIDDEN";

    /// <summary>
    /// The resource already exists type.
    /// </summary>
    public const string ResourceAlreadyExistsType = "RESOURCE_ALREADY_EXISTS";

    /// <summary>
    /// The resource create failed type.
    /// </summary>
    public const string ResourceCreateFailedType = "RESOURCE_CREATE_FAILED";

    /// <summary>
    /// The resource delete failed type.
    /// </summary>
    public const string ResourceDeleteFailedType = "RESOURCE_DELETE_FAILED";

    /// <summary>
    /// The resource not found type.
    /// </summary>
    public const string ResourceNotFoundType = "RESOURCE_NOT_FOUND";

    /// <summary>
    /// The resource patch failed type.
    /// </summary>
    public const string ResourcePatchFailedType = "RESOURCE_PATCH_FAILED";

    /// <summary>
    /// The resource update failed type.
    /// </summary>
    public const string ResourceUpdateFailedType = "RESOURCE_UPDATE_FAILED";

    /// <summary>
    /// The unauthorized error type.
    /// </summary>
    public const string UnauthorizedType = "UNAUTHORIZED";

    /// <summary>
    /// The unexpected error type.
    /// </summary>
    public const string UnexpectedErrorType = "UNEXPECTED_ERROR";
}