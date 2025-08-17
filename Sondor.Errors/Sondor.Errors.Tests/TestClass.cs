using System.Diagnostics.CodeAnalysis;

namespace Sondor.Errors.Tests;

/// <summary>
/// The test class.
/// </summary>
[ExcludeFromCodeCoverage]
public class TestClass
{
    /// <summary>
    /// The name.
    /// </summary>
    public string Name { get; } = string.Empty;

    /// <summary>
    /// The alias.
    /// </summary>
    public string? Alias { get; } = null;

    /// <summary>
    /// The test values.
    /// </summary>
    public string[] Values { get; init; } = [];

    /// <summary>
    /// The created date time offset.
    /// </summary>
    public DateTimeOffset Created { get; } = default;
}
