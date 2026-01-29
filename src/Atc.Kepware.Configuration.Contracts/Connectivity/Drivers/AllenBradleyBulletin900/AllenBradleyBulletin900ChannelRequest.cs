namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyBulletin900;

/// <summary>
/// Channel request properties for the Allen-Bradley Bulletin 900 driver.
/// </summary>
public sealed class AllenBradleyBulletin900ChannelRequest : ChannelRequestBase, IAllenBradleyBulletin900ChannelRequest
{
    public AllenBradleyBulletin900ChannelRequest()
        : base(DriverType.AllenBradleyBulletin900)
    {
        NonNormalizedFloatingPointHandling = ChannelNonNormalizedFloatingPointHandlingType.Unmodified;
    }

    /// <inheritdoc />
    public Bulletin900SerialPhysicalMediumType PhysicalMedium { get; set; } = Bulletin900SerialPhysicalMediumType.ComPort;

    /// <inheritdoc />
    public Bulletin900SerialReadProcessingType? ReadProcessing { get; set; }

    /// <inheritdoc />
    [Range(1, 999)]
    public int? ComId { get; set; } = 1;

    /// <inheritdoc />
    public Bulletin900BaudRateType? BaudRate { get; set; } = Bulletin900BaudRateType.Baud9600;

    /// <inheritdoc />
    public Bulletin900DataBitsType? DataBits { get; set; } = Bulletin900DataBitsType.DataBits7;

    /// <inheritdoc />
    public Bulletin900ParityType? Parity { get; set; } = Bulletin900ParityType.Even;

    /// <inheritdoc />
    public Bulletin900StopBitsType? StopBits { get; set; } = Bulletin900StopBitsType.StopBits2;

    /// <inheritdoc />
    public Bulletin900FlowControlType? FlowControl { get; set; } = Bulletin900FlowControlType.None;

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public bool? ReportCommunicationErrors { get; set; } = true;

    /// <inheritdoc />
    public bool? CloseIdleConnection { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 99)]
    public int? IdleTimeToClose { get; set; } = 15;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PhysicalMedium)}: {PhysicalMedium}, {nameof(ComId)}: {ComId}, {nameof(BaudRate)}: {BaudRate}";
}