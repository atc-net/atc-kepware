namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Ping;

/// <summary>
/// Represents a Ping channel creation request.
/// </summary>
public class PingChannelRequest : ChannelRequestBase, IPingChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PingChannelRequest"/> class.
    /// </summary>
    public PingChannelRequest()
        : base(DriverType.Ping)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
