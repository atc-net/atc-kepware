namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.AromatEthernet;

/// <summary>
/// Aromat Ethernet request size type.
/// </summary>
/// <remarks>
/// Specifies the request size in bytes. This determines the maximum number of bytes the driver can request in a transaction.
/// </remarks>
[SuppressMessage("Design", "CA1027:Mark enums with FlagsAttribute", Justification = "Values represent byte sizes, not flags")]
public enum AromatEthernetRequestSizeType
{
    /// <summary>
    /// None - not set.
    /// </summary>
    None = 0,

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
