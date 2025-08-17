using Sondor.Errors.Attributes;
using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Extensions;

/// <summary>
/// Collection of <see cref="int"/> extensions.
/// </summary>
public static class IntExtensions
{
    /// <summary>
    /// Converts an error code to its corresponding <typeparamref name="TEnum" /> value.
    /// </summary>
    /// <param name="errorCode">The error code.</param>
    /// <typeparam name="TEnum">The enum type.</typeparam>
    /// <returns>Returns the appropriate application translation.</returns>
    /// <exception cref="UnsupportedErrorCodeException">This exception is thrown when an unsupported error code is encountered.</exception>
    public static TEnum ToEnum<TEnum>(this int errorCode)
        where TEnum : struct, Enum
    {
        var values = Enum.GetValues(typeof(TEnum));

        foreach (var value in values)
        {
            var memberInfo = typeof(TEnum).GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(SondorErrorCodeAttribute), false)
                .Cast<SondorErrorCodeAttribute>()
                .ToArray();

            if (attributes.Length == 0)
            {
                continue;
            }

            if (attributes.Any(attribute => attribute.ErrorCode.Equals(errorCode)))
            {
                return (TEnum)value;
            }
        }

        throw new UnsupportedErrorCodeException(errorCode);
    }

    /// <summary>
    /// Determines if <paramref name="value"/> is a Sondor error code.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>Returns true, if <paramref name="value"/> is a valid error code, otherwise false.</returns>
    public static bool IsSondorErrorCode(this int value)
    {
        return value > 0 &&
            SondorErrorCodes.ErrorCodes.Contains(value);
    }
}