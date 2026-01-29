namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaCxEthernet;

/// <summary>
/// Yokogawa CX Ethernet channel request.
/// </summary>
public class YokogawaCxEthernetChannelRequest : ChannelRequestBase, IYokogawaCxEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaCxEthernetChannelRequest"/> class.
    /// </summary>
    public YokogawaCxEthernetChannelRequest()
        : base(DriverType.YokogawaCxEthernet)
    {
    }
}