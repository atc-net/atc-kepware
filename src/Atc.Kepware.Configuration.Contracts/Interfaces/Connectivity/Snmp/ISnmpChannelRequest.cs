namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Snmp;

/// <summary>
/// Defines the SNMP channel request properties.
/// </summary>
/// <remarks>
/// The SNMP driver uses standard channel properties only.
/// Network adapter is specified via servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING.
/// </remarks>
public interface ISnmpChannelRequest : IChannelRequestBase
{
}
