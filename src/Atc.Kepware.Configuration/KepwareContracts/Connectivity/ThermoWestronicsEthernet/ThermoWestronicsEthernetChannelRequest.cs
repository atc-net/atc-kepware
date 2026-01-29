namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ThermoWestronicsEthernet;

/// <summary>
/// Thermo Westronics Ethernet channel request - Kepware format.
/// </summary>
internal sealed class ThermoWestronicsEthernetChannelRequest : ChannelRequestBase, IThermoWestronicsEthernetChannelRequest
{
    public ThermoWestronicsEthernetChannelRequest()
        : base(DriverType.ThermoWestronicsEthernet)
    {
    }
}