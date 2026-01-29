namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyBulletin900;

/// <summary>
/// Channel request properties for the Allen-Bradley Bulletin 900 driver.
/// </summary>
internal sealed class AllenBradleyBulletin900ChannelRequest : ChannelRequestBase, IAllenBradleyBulletin900ChannelRequest
{
    public AllenBradleyBulletin900ChannelRequest()
        : base(DriverType.AllenBradleyBulletin900)
    {
        NonNormalizedFloatingPointHandling = ChannelNonNormalizedFloatingPointHandlingType.Unmodified;
    }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_PHYSICAL_MEDIUM")]
    public Bulletin900SerialPhysicalMediumType PhysicalMedium { get; set; } = Bulletin900SerialPhysicalMediumType.ComPort;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_READ_PROCESSING")]
    public Bulletin900SerialReadProcessingType? ReadProcessing { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_COM_ID")]
    public int? ComId { get; set; } = 1;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_BAUD_RATE")]
    public Bulletin900BaudRateType? BaudRate { get; set; } = Bulletin900BaudRateType.Baud9600;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_DATA_BITS")]
    public Bulletin900DataBitsType? DataBits { get; set; } = Bulletin900DataBitsType.DataBits7;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_PARITY")]
    public Bulletin900ParityType? Parity { get; set; } = Bulletin900ParityType.Even;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_STOP_BITS")]
    public Bulletin900StopBitsType? StopBits { get; set; } = Bulletin900StopBitsType.StopBits2;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_FLOW_CONTROL")]
    public Bulletin900FlowControlType? FlowControl { get; set; } = Bulletin900FlowControlType.None;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_REPORT_COMM_ERRORS")]
    public bool? ReportCommunicationErrors { get; set; } = true;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_CLOSE_IDLE_CONNECTION")]
    public bool? CloseIdleConnection { get; set; } = true;

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_IDLE_TIME_BEFORE_CLOSE_SEC")]
    public int? IdleTimeToClose { get; set; } = 15;

    public override string ToString()
        => $"{base.ToString()}, {nameof(PhysicalMedium)}: {PhysicalMedium}, {nameof(ComId)}: {ComId}, {nameof(BaudRate)}: {BaudRate}";
}