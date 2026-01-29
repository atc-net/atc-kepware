namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.TorqueToolEthernet;

/// <summary>
/// Channel properties for the Torque Tool Ethernet driver.
/// </summary>
public sealed class TorqueToolEthernetChannelRequest : ChannelRequestBase, ITorqueToolEthernetChannelRequest
{
    public TorqueToolEthernetChannelRequest()
        : base(DriverType.TorqueToolEthernet)
    {
    }
}
