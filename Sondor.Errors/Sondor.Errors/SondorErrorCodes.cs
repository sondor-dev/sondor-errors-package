namespace Sondor.Errors;

/// <summary>
/// Collection of Sondor error codes.
/// </summary>
public static class SondorErrorCodes
{
    /// <summary>
    /// The unexpected error code.
    /// </summary>
    public const int UnexpectedError = 1000;

    /// <summary>
    /// The resource not found error code.
    /// </summary>
    public const int ResourceNotFound = 1001;

    /// <summary>
    /// The resource create failed error code.
    /// </summary>
    public const int ResourceCreateFailed = 1002;

    /// <summary>
    /// The resource update failed error code.
    /// </summary>
    public const int ResourceUpdateFailed = 1003;

    /// <summary>
    /// The resource delete failed error code.
    /// </summary>
    public const int ResourceDeleteFailed = 1004;

    /// <summary>
    /// The resource patch failed error code.
    /// </summary>
    public const int ResourcePatchFailed = 1005;

    /// <summary>
    /// The resource already exists error code.
    /// </summary>
    public const int ResourceAlreadyExists = 1006;

    /// <summary>
    /// The unauthorized error code.
    /// </summary>
    public const int Unauthorized = 1007;

    /// <summary>
    /// The forbidden error code.
    /// </summary>
    public const int Forbidden = 1008;

    /// <summary>
    /// The bad request error code.
    /// </summary>
    public const int BadRequest = 1009;
}
