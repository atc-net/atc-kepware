namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiCncEthernet;

/// <summary>
/// Mitsubishi CNC Ethernet channel request.
/// </summary>
public class MitsubishiCncEthernetChannelRequest : ChannelRequestBase, IMitsubishiCncEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MitsubishiCncEthernetChannelRequest"/> class.
    /// </summary>
    public MitsubishiCncEthernetChannelRequest()
        : base(DriverType.MitsubishiCncEthernet)
    {
    }
}