using System.Text.Json.Serialization;

namespace Sondor.Errors;

/// <summary>
/// The error type.
/// </summary>
/// <remarks>
/// Creates a new instance of <see cref="SondorError"/>.
/// </remarks>
/// <param name="context">The context data.</param>
/// <param name="errorCode">The error code.</param>
/// <param name="errorType">The error type.</param>
/// <param name="errorDescription">The error description.</param>
[method: JsonConstructor]
public readonly struct SondorError(int errorCode,
    string errorType,
    string errorDescription,
    Dictionary<string, object?>? context = null) : IEquatable<SondorError>
{
    /// <summary>
    /// The error code.
    /// </summary>
    public int ErrorCode { get; } = errorCode;

    /// <summary>
    /// The error type.
    /// </summary>
    public string ErrorType { get; } = errorType;

    /// <summary>
    /// The error description.
    /// </summary>
    public string ErrorDescription { get; } = errorDescription;

    /// <summary>
    /// The context.
    /// </summary>
    public Dictionary<string, object?> Context { get; } = context ?? new Dictionary<string, object?>();

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        if (obj is not SondorError error)
        {
            return false;
        }

        return error.ErrorCode.Equals(ErrorCode) &&
               error.ErrorType.Equals(ErrorType) &&
               error.ErrorDescription.Equals(ErrorDescription);
    }

    /// <inheritdoc />
    public bool Equals(SondorError other)
    {
        return
            ErrorCode.Equals(other.ErrorCode) &&
            ErrorType.Equals(other.ErrorType) &&
            ErrorDescription.Equals(other.ErrorDescription);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
#if NETSTANDARD2_0
        // .NET Standard 2.0 does not support HashCode.Combine
        // Use a custom hash code calculation
        var hash = 17;
        
        hash = hash * 31 + ErrorCode.GetHashCode();
        hash = hash * 31 + (ErrorType?.GetHashCode() ?? 0);
        hash = hash * 31 + (ErrorDescription?.GetHashCode() ?? 0);
        
        return hash;
#elif NETSTANDARD2_1 || NETCOREAPP
        return HashCode.Combine(ErrorCode, ErrorType, ErrorDescription);
#endif
    }

    /// <summary>
    /// Determines if <paramref name="error"/> is not equal to <paramref name="error2"/>.
    /// </summary>
    /// <param name="error">The error.</param>
    /// <param name="error2">The error 2</param>
    /// <returns>Returns true if they do not match, otherwise false.</returns>
    public static bool operator !=(SondorError error, SondorError error2)
    {
        return !(error.ErrorCode.Equals(error2.ErrorCode) &&
            error.ErrorType.Equals(error2.ErrorType) &&
            error.ErrorDescription.Equals(error2.ErrorDescription));
    }

    /// <summary>
    /// Determines if <paramref name="error"/> is equal to <paramref name="error2"/>.
    /// </summary>
    /// <param name="error">The error.</param>
    /// <param name="error2">The error 2</param>
    /// <returns>Returns true if they do not match, otherwise false.</returns>
    public static bool operator ==(SondorError error, SondorError error2)
    {
        return
            error.ErrorCode.Equals(error2.ErrorCode) &&
            error.ErrorType.Equals(error2.ErrorType) &&
            error.ErrorDescription.Equals(error2.ErrorDescription);
    }
}