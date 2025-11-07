namespace Sondor.Errors;

/// <summary>
/// Sondor result type interface.
/// </summary>
public interface ISondorResult
{
    /// <summary>
    /// The error.
    /// </summary>
    SondorError? Error { get; }

    /// <summary>
    /// Determines if the result is valid.
    /// </summary>
    bool IsValid { get; }
}

/// <summary>
/// Sondor result type interface.
/// </summary>
/// <typeparam name="TResult">The result type.</typeparam>
public interface ISondorResult<out TResult>
{
    /// <summary>
    /// The result.
    /// </summary>
    TResult? Result { get; }
}