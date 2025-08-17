namespace Sondor.Errors.Attributes;

/// <summary>
/// Error code attribute.
/// </summary>
/// <remarks>
/// Create a new instance of <see cref="SondorErrorCodeAttribute"/>.
/// </remarks>
/// <param name="errorCode">The error code.</param>
[AttributeUsage(AttributeTargets.Field)]
public class SondorErrorCodeAttribute(int errorCode) : Attribute
{
    /// <summary>
    /// The error code.
    /// </summary>
    public int ErrorCode { get; } = errorCode;
}