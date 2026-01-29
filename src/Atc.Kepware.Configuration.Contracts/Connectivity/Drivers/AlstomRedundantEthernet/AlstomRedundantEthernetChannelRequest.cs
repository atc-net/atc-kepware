namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AlstomRedundantEthernet;

/// <summary>
/// Channel request properties for the Alstom Redundant Ethernet driver.
/// </summary>
public sealed class AlstomRedundantEthernetChannelRequest : ChannelRequestBase, IAlstomRedundantEthernetChannelRequest
{
    public AlstomRedundantEthernetChannelRequest()
        : base(DriverType.AlstomRedundantEthernet)
    {
    }

    /// <inheritdoc />
    public string? PrimaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    public string? SecondaryNetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PrimaryNetworkAdapter)}: {PrimaryNetworkAdapter}, {nameof(SecondaryNetworkAdapter)}: {SecondaryNetworkAdapter}";
}