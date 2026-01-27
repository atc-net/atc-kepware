namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaDarwinEthernet;

/// <summary>
/// Yokogawa Darwin Ethernet channel request.
/// </summary>
public class YokogawaDarwinEthernetChannelRequest : ChannelRequestBase, IYokogawaDarwinEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaDarwinEthernetChannelRequest"/> class.
    /// </summary>
    public YokogawaDarwinEthernetChannelRequest()
        : base(DriverType.YokogawaDarwinEthernet)
    {
    }
}
