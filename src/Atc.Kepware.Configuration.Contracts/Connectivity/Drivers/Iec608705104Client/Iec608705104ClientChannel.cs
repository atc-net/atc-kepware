namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Iec608705104Client;

/// <summary>
/// Represents an IEC 60870-5-104 Client channel.
/// </summary>
public class Iec608705104ClientChannel : ChannelBase, IIec608705104ClientChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public string DestinationHost { get; set; } = string.Empty;

    /// <inheritdoc />
    public int DestinationPort { get; set; }

    /// <inheritdoc />
    public int ConnectTimeout { get; set; }

    /// <inheritdoc />
    public Iec608705104CotSizeType CotSize { get; set; }

    /// <inheritdoc />
    public int OriginatorAddress { get; set; }

    /// <inheritdoc />
    public int T1 { get; set; }

    /// <inheritdoc />
    public int T2 { get; set; }

    /// <inheritdoc />
    public int T3 { get; set; }

    /// <inheritdoc />
    public int K { get; set; }

    /// <inheritdoc />
    public int W { get; set; }

    /// <inheritdoc />
    public int RxBufferSize { get; set; }

    /// <inheritdoc />
    public int IncrementalTimeout { get; set; }

    /// <inheritdoc />
    public int FirstCharWait { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DestinationHost)}: {DestinationHost}, {nameof(DestinationPort)}: {DestinationPort}";
}
