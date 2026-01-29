namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.TorqueToolEthernet;

/// <summary>
/// Torque Tool Ethernet channel request - Kepware format.
/// </summary>
internal sealed class TorqueToolEthernetChannelRequest : ChannelRequestBase, ITorqueToolEthernetChannelRequest
{
    public TorqueToolEthernetChannelRequest()
        : base(DriverType.TorqueToolEthernet)
    {
    }
}