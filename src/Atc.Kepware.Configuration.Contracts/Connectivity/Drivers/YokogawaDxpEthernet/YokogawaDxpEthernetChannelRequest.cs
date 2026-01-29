namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaDxpEthernet;

/// <summary>
/// Yokogawa DXP Ethernet channel request.
/// </summary>
public class YokogawaDxpEthernetChannelRequest : ChannelRequestBase, IYokogawaDxpEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaDxpEthernetChannelRequest"/> class.
    /// </summary>
    public YokogawaDxpEthernetChannelRequest()
        : base(DriverType.YokogawaDxpEthernet)
    {
    }
}