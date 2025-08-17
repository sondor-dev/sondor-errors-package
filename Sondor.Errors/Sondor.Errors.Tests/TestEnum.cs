using Sondor.Errors.Attributes;
using System.Xml.Serialization;

namespace Sondor.Errors.Tests;

/// <summary>
/// The test enums.
/// </summary>
public enum TestEnum
{
    /// <summary>
    /// The default, unrecognised value.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Value 1.
    /// </summary>
    [XmlAttribute]
    [SondorErrorCode(SondorErrorCodes.BadRequest)]
    Value1 = 1,

    /// <summary>
    /// Value 2.
    /// </summary>
    [SondorErrorCode(SondorErrorCodes.ResourceNotFound)]
    Value2 = 2,
}
