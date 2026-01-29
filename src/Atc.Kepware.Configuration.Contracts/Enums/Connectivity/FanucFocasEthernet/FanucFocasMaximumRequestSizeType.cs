namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.FanucFocasEthernet;

/// <summary>
/// Fanuc Focas Ethernet maximum request size types.
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values represent actual byte sizes from API.")]
[SuppressMessage("Design", "CA1027:Mark enums with FlagsAttribute", Justification = "Not a flags enum; values are byte sizes.")]
public enum FanucFocasMaximumRequestSizeType
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
    /// 256 bytes (default).
    /// </summary>
    Bytes256 = 256,

    /// <summary>
    /// 512 bytes.
    /// </summary>
    Bytes512 = 512,
}