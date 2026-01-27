namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiCncEthernet;

/// <summary>
/// Mitsubishi CNC Ethernet channel request - Kepware format.
/// </summary>
internal sealed class MitsubishiCncEthernetChannelRequest : ChannelRequestBase, IMitsubishiCncEthernetChannelRequest
{
    public MitsubishiCncEthernetChannelRequest()
        : base(DriverType.MitsubishiCncEthernet)
    {
    }
}
