namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet channel request.
/// </summary>
public class YokogawaGxEthernetChannelRequest : ChannelRequestBase, IYokogawaGxEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaGxEthernetChannelRequest"/> class.
    /// </summary>
    public YokogawaGxEthernetChannelRequest()
        : base(DriverType.YokogawaGxEthernet)
    {
    }
}