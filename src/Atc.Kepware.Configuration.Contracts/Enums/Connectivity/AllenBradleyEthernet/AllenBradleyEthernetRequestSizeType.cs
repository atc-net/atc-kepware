namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.AllenBradleyEthernet;

/// <summary>
/// Allen-Bradley Ethernet request size types (in bytes).
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API")]
public enum AllenBradleyEthernetRequestSizeType
{
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
    /// 512 bytes (default).
    /// </summary>
    Bytes512 = 512,

    /// <summary>
    /// 1024 bytes.
    /// </summary>
    Bytes1024 = 1024,

    /// <summary>
    /// 2000 bytes.
    /// </summary>
    Bytes2000 = 2000,
}