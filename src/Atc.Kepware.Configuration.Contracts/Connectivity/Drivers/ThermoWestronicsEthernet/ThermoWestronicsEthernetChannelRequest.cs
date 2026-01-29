namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ThermoWestronicsEthernet;

/// <summary>
/// Thermo Westronics Ethernet channel request.
/// </summary>
public class ThermoWestronicsEthernetChannelRequest : ChannelRequestBase, IThermoWestronicsEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ThermoWestronicsEthernetChannelRequest"/> class.
    /// </summary>
    public ThermoWestronicsEthernetChannelRequest()
        : base(DriverType.ThermoWestronicsEthernet)
    {
    }
}
