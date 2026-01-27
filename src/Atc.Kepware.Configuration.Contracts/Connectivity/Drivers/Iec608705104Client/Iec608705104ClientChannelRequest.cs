namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Iec608705104Client;

/// <summary>
/// Represents an IEC 60870-5-104 Client channel creation request.
/// </summary>
public class Iec608705104ClientChannelRequest : ChannelRequestBase, IIec608705104ClientChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Iec608705104ClientChannelRequest"/> class.
    /// </summary>
    public Iec608705104ClientChannelRequest()
        : base(DriverType.Iec608705104Client)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [MaxLength(255)]
    public string DestinationHost { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 65535)]
    public int DestinationPort { get; set; } = 2404;

    /// <inheritdoc />
    [Range(1, 255)]
    public int ConnectTimeout { get; set; } = 3;

    /// <inheritdoc />
    public Iec608705104CotSizeType CotSize { get; set; } = Iec608705104CotSizeType.TwoOctets;

    /// <inheritdoc />
    [Range(0, 254)]
    public int OriginatorAddress { get; set; }

    /// <inheritdoc />
    [Range(1, 255)]
    public int T1 { get; set; } = 15;

    /// <inheritdoc />
    [Range(1, 255)]
    public int T2 { get; set; } = 10;

    /// <inheritdoc />
    [Range(1, 172800)]
    public int T3 { get; set; } = 20;

    /// <inheritdoc />
    [Range(1, 12)]
    public int K { get; set; } = 12;

    /// <inheritdoc />
    [Range(1, 65535)]
    public int W { get; set; } = 8;

    /// <inheritdoc />
    [Range(2, 253)]
    public int RxBufferSize { get; set; } = 253;

    /// <inheritdoc />
    [Range(10, int.MaxValue)]
    public int IncrementalTimeout { get; set; } = 30000;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int FirstCharWait { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DestinationHost)}: {DestinationHost}, {nameof(DestinationPort)}: {DestinationPort}";
}
