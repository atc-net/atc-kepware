namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.GeEthernet;

/// <summary>
/// GE Ethernet maximum bytes per request.
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API")]
[SuppressMessage("Design", "CA1027:Mark enums with FlagsAttribute", Justification = "Not a flags enum - values represent discrete byte sizes")]
public enum GeEthernetMaxBytesPerRequest
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
    /// 512 bytes.
    /// </summary>
    Bytes512 = 512,

    /// <summary>
    /// 1024 bytes.
    /// </summary>
    Bytes1024 = 1024,

    /// <summary>
    /// 2048 bytes.
    /// </summary>
    Bytes2048 = 2048,
}
