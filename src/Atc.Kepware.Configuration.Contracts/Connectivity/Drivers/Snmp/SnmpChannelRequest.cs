namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Snmp;

/// <summary>
/// Represents an SNMP channel creation request.
/// </summary>
/// <remarks>
/// The SNMP driver uses standard channel properties only.
/// </remarks>
public class SnmpChannelRequest : ChannelRequestBase, ISnmpChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SnmpChannelRequest"/> class.
    /// </summary>
    public SnmpChannelRequest()
        : base(DriverType.Snmp)
    {
    }
}
