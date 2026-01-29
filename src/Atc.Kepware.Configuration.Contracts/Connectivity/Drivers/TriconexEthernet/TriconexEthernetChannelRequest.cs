namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.TriconexEthernet;

/// <summary>
/// Represents a Triconex Ethernet channel creation request.
/// </summary>
public class TriconexEthernetChannelRequest : ChannelRequestBase, ITriconexEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TriconexEthernetChannelRequest"/> class.
    /// </summary>
    public TriconexEthernetChannelRequest()
        : base(DriverType.TriconexEthernet)
    {
    }

    /// <inheritdoc />
    public bool EnableNetworkRedundancy { get; set; }

    /// <inheritdoc />
    public string? PrimaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    public string? SecondaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(EnableNetworkRedundancy)}: {EnableNetworkRedundancy}, {nameof(PrimaryNetworkAdapter)}: {PrimaryNetworkAdapter}, {nameof(SecondaryNetworkAdapter)}: {SecondaryNetworkAdapter}";
}
