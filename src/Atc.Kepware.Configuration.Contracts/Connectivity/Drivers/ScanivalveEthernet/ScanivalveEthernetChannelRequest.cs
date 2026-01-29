namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ScanivalveEthernet;

/// <summary>
/// Channel properties for the Scanivalve Ethernet driver.
/// </summary>
public sealed class ScanivalveEthernetChannelRequest : ChannelRequestBase, IScanivalveEthernetChannelRequest
{
    public ScanivalveEthernetChannelRequest()
        : base(DriverType.ScanivalveEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
