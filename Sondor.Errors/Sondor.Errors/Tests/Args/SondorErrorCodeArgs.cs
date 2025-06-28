using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Sondor.Errors.Tests.Args;

/// <summary>
/// Collection of <see cref="SondorErrorCodes"/> test arguments.
/// </summary>
#if !NETSTANDARD2_0 && !NETSTANDARD2_1
[ExcludeFromCodeCoverage(Justification = "Intended for external use, to improve testability of the package.")]
#else
[ExcludeFromCodeCoverage]
#endif
public class SondorErrorCodeArgs :
    IEnumerable
{
    /// <inheritdoc />
    public IEnumerator GetEnumerator()
    {
        yield return SondorErrorCodes.UnexpectedError;
        yield return SondorErrorCodes.ResourceNotFound;
        yield return SondorErrorCodes.ResourceCreateFailed;
        yield return SondorErrorCodes.ResourceUpdateFailed;
        yield return SondorErrorCodes.ResourceDeleteFailed;
        yield return SondorErrorCodes.ResourcePatchFailed;
        yield return SondorErrorCodes.ResourceAlreadyExists;
        yield return SondorErrorCodes.Unauthorized;
        yield return SondorErrorCodes.Forbidden;
        yield return SondorErrorCodes.BadRequest;
    }
}