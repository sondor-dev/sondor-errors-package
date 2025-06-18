using System.Text.Json.Serialization;

namespace Sondor.Errors;

/// <summary>
/// Sondor result type.
/// </summary>
public readonly struct SondorResult
{
    /// <summary>
    /// The error.
    /// </summary>
    public SondorError? Error { get; }

    /// <summary>
    /// Determines if the result is valid.
    /// </summary>
    public bool IsValid => Error is null;

    /// <summary>
    /// Creates a new instance of <see cref="SondorResult"/>.
    /// </summary>
    /// <param name="error">The error.</param>
    [JsonConstructor]
    public SondorResult(SondorError? error)
    {
        Error = error;
    }

    /// <summary>
    /// Implicit to <see cref="bool"/>.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator bool(SondorResult result)
    {
        return result.IsValid;
    }

    /// <summary>
    /// Explicit from <see cref="SondorError"/>.
    /// </summary>
    /// <param name="error">The error.</param>
    public static explicit operator SondorResult(SondorError error)
    {
        return new SondorResult(error);
    }
}

/// <summary>
/// Sondor result type.
/// </summary>
/// <typeparam name="TResult">The result type.</typeparam>
public readonly struct SondorResult<TResult>
{
    /// <summary>
    /// The result.
    /// </summary>
    public TResult? Result { get; }

    /// <summary>
    /// The error.
    /// </summary>
    public SondorError? Error { get; }

    /// <summary>
    /// Determines if the result is valid.
    /// </summary>
    public bool IsValid => Error is null;

    /// <summary>
    /// Creates a new instance of <see cref="SondorResult{TResult}"/>.
    /// </summary>
    /// <param name="result">The result.</param>
    public SondorResult(TResult result)
    {
        Result = result;
        Error = null;
    }

    /// <summary>
    /// Creates a new instance of <see cref="SondorResult{TResult}"/>.
    /// </summary>
    /// <param name="error">The error.</param>
    public SondorResult(SondorError? error)
    {
        Error = error;
        Result = default;
    }

    /// <summary>
    /// Creates a new instance of <see cref="SondorResult{TResult}"/>.
    /// </summary>
    /// <param name="error">The error.</param>
    /// <param name="result">The result.</param>
    [JsonConstructor]
    internal SondorResult(TResult? result, SondorError? error)
    {
        Error = error;
        Result = result;
    }

    /// <summary>
    /// Implicit to <see cref="bool"/>.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator bool(SondorResult<TResult> result)
    {
        return result.IsValid;
    }

    /// <summary>
    /// Implicit to <see cref="SondorResult"/>.
    /// </summary>
    /// <param name="result">The result.</param>
    public static implicit operator SondorResult(SondorResult<TResult> result)
    {
        return new SondorResult(result.Error);
    }

    /// <summary>
    /// Explicit from <see cref="SondorError"/>.
    /// </summary>
    /// <param name="error">The error.</param>
    public static explicit operator SondorResult<TResult>(SondorError error)
    {
        return new SondorResult<TResult>(error);
    }
}