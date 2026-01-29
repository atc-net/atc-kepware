// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specifies the device archive number for Omni Flow Computer meters.
/// A value of zero (0) disables the archive.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/omni_meters
/// Section: omni_flow_computer.METER_*_ARCHIVE_NUMBER
/// </remarks>
public enum OmniArchiveNumber
{
    /// <summary>
    /// Archive disabled.
    /// </summary>
    Zero = 0,

    /// <summary>
    /// Archive number 1.
    /// </summary>
    One = 1,

    /// <summary>
    /// Archive number 2.
    /// </summary>
    Two = 2,

    /// <summary>
    /// Archive number 3.
    /// </summary>
    Three = 3,

    /// <summary>
    /// Archive number 4.
    /// </summary>
    Four = 4,

    /// <summary>
    /// Archive number 5.
    /// </summary>
    Five = 5,

    /// <summary>
    /// Archive number 6.
    /// </summary>
    Six = 6,

    /// <summary>
    /// Archive number 7.
    /// </summary>
    Seven = 7,

    /// <summary>
    /// Archive number 8.
    /// </summary>
    Eight = 8,

    /// <summary>
    /// Archive number 9.
    /// </summary>
    Nine = 9,

    /// <summary>
    /// Archive number 10.
    /// </summary>
    Ten = 10,
}