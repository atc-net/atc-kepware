namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Ping;

/// <summary>
/// Represents a Ping channel.
/// </summary>
public class PingChannel : ChannelBase, IPingChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}