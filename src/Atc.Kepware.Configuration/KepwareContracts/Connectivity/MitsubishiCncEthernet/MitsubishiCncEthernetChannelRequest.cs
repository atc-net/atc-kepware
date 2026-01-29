namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MitsubishiCncEthernet;

/// <summary>
/// Mitsubishi CNC Ethernet channel request.
/// </summary>
internal sealed class MitsubishiCncEthernetChannelRequest : ChannelRequestBase, IMitsubishiCncEthernetChannelRequest
{
    public MitsubishiCncEthernetChannelRequest()
        : base(DriverType.MitsubishiCncEthernet)
    {
    }
}