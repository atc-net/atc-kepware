namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.YokogawaDxEthernet;

/// <summary>
/// Yokogawa DX Ethernet channel request.
/// </summary>
public class YokogawaDxEthernetChannelRequest : ChannelRequestBase, IYokogawaDxEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="YokogawaDxEthernetChannelRequest"/> class.
    /// </summary>
    public YokogawaDxEthernetChannelRequest()
        : base(DriverType.YokogawaDxEthernet)
    {
    }
}