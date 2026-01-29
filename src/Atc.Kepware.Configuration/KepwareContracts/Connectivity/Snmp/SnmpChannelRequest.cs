namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Snmp;

/// <summary>
/// Channel request properties for the SNMP driver.
/// </summary>
/// <remarks>
/// The SNMP driver uses standard channel properties only.
/// </remarks>
internal sealed class SnmpChannelRequest : ChannelRequestBase, ISnmpChannelRequest
{
    public SnmpChannelRequest()
        : base(DriverType.Snmp)
    {
    }
}
