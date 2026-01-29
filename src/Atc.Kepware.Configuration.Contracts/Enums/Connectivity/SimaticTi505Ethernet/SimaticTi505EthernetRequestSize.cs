namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet request size.
/// </summary>
[SuppressMessage("Naming", "CA1027:Mark enums with FlagsAttribute", Justification = "OK - Values are not flags.")]
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "OK - Kepware defined values.")]
public enum SimaticTi505EthernetRequestSize
{
    /// <summary>
    /// 32 bytes.
    /// </summary>
    [Description("32 Bytes")]
    Bytes32 = 32,

    /// <summary>
    /// 64 bytes.
    /// </summary>
    [Description("64 Bytes")]
    Bytes64 = 64,

    /// <summary>
    /// 128 bytes.
    /// </summary>
    [Description("128 Bytes")]
    Bytes128 = 128,

    /// <summary>
    /// 250 bytes.
    /// </summary>
    [Description("250 Bytes")]
    Bytes250 = 250,
}
