namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaMwEthernet;

/// <summary>
/// Yokogawa MW Ethernet channel request.
/// </summary>
public class YokogawaMwEthernetChannelRequest : ChannelRequestBase, IYokogawaMwEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaMwEthernetChannelRequest"/> class.
    /// </summary>
    public YokogawaMwEthernetChannelRequest()
        : base(DriverType.YokogawaMwEthernet)
    {
    }
}
