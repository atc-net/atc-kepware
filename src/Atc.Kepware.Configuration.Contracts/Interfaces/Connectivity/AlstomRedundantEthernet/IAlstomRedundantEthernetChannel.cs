namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AlstomRedundantEthernet;

/// <summary>
/// Interface for Alstom Redundant Ethernet channel properties.
/// </summary>
public interface IAlstomRedundantEthernetChannel : IChannelBase
{
    /// <summary>
    /// Specify the Network Interface Card (NIC) that should be used to connect to the primary network.
    /// </summary>
    string? PrimaryNetworkAdapter { get; set; }

    /// <summary>
    /// Specify the Network Interface Card (NIC) that should be used to connect to the secondary network.
    /// </summary>
    string? SecondaryNetworkAdapter { get; set; }
}