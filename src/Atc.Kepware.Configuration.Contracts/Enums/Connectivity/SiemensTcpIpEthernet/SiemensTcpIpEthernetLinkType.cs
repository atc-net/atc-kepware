namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.SiemensTcpIpEthernet;

/// <summary>
/// Siemens TCP/IP Ethernet link types.
/// </summary>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API")]
public enum SiemensTcpIpEthernetLinkType
{
    /// <summary>
    /// PG (Programming Device) connection.
    /// </summary>
    PG = 1,

    /// <summary>
    /// OP (Operator Panel) connection.
    /// </summary>
    OP = 2,

    /// <summary>
    /// PC (default) connection.
    /// </summary>
    PC = 3,
}
