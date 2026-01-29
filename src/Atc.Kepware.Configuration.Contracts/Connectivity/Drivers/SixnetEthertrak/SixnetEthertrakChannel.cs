namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SixnetEthertrak;

/// <summary>
/// Represents a SIXNET EtherTRAK channel.
/// </summary>
public class SixnetEthertrakChannel : ChannelBase, ISixnetEthertrakChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}