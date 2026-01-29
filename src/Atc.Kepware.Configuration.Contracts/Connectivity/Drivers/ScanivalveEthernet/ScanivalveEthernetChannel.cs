namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ScanivalveEthernet;

public sealed class ScanivalveEthernetChannel : ChannelBase, IScanivalveEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
