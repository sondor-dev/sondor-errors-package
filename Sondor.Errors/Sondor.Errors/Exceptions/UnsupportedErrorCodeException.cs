using Sondor.Errors.Constants;

namespace Sondor.Errors.Exceptions;

/// <summary>
/// Unsupported error code exception.
/// </summary>
/// <remarks>
/// Creates a new instance of the <see cref="UnsupportedErrorCodeException"/>.
/// </remarks>
/// <param name="errorCode">The error code.</param>
public class UnsupportedErrorCodeException(int errorCode)
    : Exception(string.Format(ExceptionConstants.UnsupportedErrorCode, errorCode))
{
    /// <summary>
    /// The error code that is unsupported.
    /// </summary>
    public int ErrorCode { get; } = errorCode;
}
