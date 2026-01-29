namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.TriconexEthernet;

/// <summary>
/// Defines the Triconex Ethernet channel request properties.
/// </summary>
public interface ITriconexEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Gets or sets a value indicating whether network redundancy is enabled.
    /// </summary>
    /// <remarks>
    /// Default value is false.
    /// </remarks>
    bool EnableNetworkRedundancy { get; set; }

    /// <summary>
    /// Gets or sets the NIC to which the primary network is connected.
    /// </summary>
    string? PrimaryNetworkAdapter { get; set; }

    /// <summary>
    /// Gets or sets the NIC to which the secondary network is connected.
    /// </summary>
    /// <remarks>
    /// Only applicable when <see cref="EnableNetworkRedundancy"/> is true.
    /// </remarks>
    string? SecondaryNetworkAdapter { get; set; }
}