// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

/// <summary>
/// Specify the maximum number of bytes to request per read transaction.
/// </summary>
/// <remarks>
/// Ref: https://{ip}:{port}/config/v1/doc/drivers/Fanuc%20Focas%20HSSB/devices
/// Section: ge_focas1_hssb.DEVICE_MAXIMUM_REQUEST_SIZE
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API.")]
[SuppressMessage("Design", "CA1027:Mark enums with FlagsAttribute", Justification = "These are specific byte size options, not flags.")]
public enum FanucFocasHssbMaximumRequestSize
{
    /// <summary>
    /// 8 bytes.
    /// </summary>
    Bytes8 = 8,

    /// <summary>
    /// 16 bytes.
    /// </summary>
    Bytes16 = 16,

    /// <summary>
    /// 32 bytes.
    /// </summary>
    Bytes32 = 32,

    /// <summary>
    /// 64 bytes.
    /// </summary>
    Bytes64 = 64,

    /// <summary>
    /// 128 bytes.
    /// </summary>
    Bytes128 = 128,

    /// <summary>
    /// 256 bytes.
    /// </summary>
    Bytes256 = 256,

    /// <summary>
    /// 512 bytes.
    /// </summary>
    Bytes512 = 512,
}