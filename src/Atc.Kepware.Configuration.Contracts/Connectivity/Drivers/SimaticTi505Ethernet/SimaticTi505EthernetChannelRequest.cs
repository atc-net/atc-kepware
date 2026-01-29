namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet channel request.
/// </summary>
public class SimaticTi505EthernetChannelRequest : ChannelRequestBase, ISimaticTi505EthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SimaticTi505EthernetChannelRequest"/> class.
    /// </summary>
    public SimaticTi505EthernetChannelRequest()
        : base(DriverType.SimaticTi505Ethernet)
    {
    }
}
