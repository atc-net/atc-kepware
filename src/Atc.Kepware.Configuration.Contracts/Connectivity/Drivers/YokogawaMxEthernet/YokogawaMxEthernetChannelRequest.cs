namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaMxEthernet;

/// <summary>
/// Yokogawa MX Ethernet channel request.
/// </summary>
public class YokogawaMxEthernetChannelRequest : ChannelRequestBase, IYokogawaMxEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaMxEthernetChannelRequest"/> class.
    /// </summary>
    public YokogawaMxEthernetChannelRequest()
        : base(DriverType.YokogawaMxEthernet)
    {
    }
}