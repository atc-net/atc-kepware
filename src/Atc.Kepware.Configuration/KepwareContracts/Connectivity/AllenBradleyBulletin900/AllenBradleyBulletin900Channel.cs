namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyBulletin900;

/// <summary>
/// Channel properties for the Allen-Bradley Bulletin 900 driver.
/// </summary>
internal sealed class AllenBradleyBulletin900Channel : ChannelBase
{
    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_PHYSICAL_MEDIUM")]
    public Bulletin900SerialPhysicalMediumType PhysicalMedium { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_READ_PROCESSING")]
    public Bulletin900SerialReadProcessingType? ReadProcessing { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_COM_ID")]
    public int? ComId { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_BAUD_RATE")]
    public Bulletin900BaudRateType? BaudRate { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_DATA_BITS")]
    public Bulletin900DataBitsType? DataBits { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_PARITY")]
    public Bulletin900ParityType? Parity { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_STOP_BITS")]
    public Bulletin900StopBitsType? StopBits { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_FLOW_CONTROL")]
    public Bulletin900FlowControlType? FlowControl { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_REPORT_COMM_ERRORS")]
    public bool? ReportCommunicationErrors { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_CLOSE_IDLE_CONNECTION")]
    public bool? CloseIdleConnection { get; set; }

    [JsonPropertyName("servermain.CHANNEL_SERIAL_COMMUNICATIONS_IDLE_TIME_BEFORE_CLOSE_SEC")]
    public int? IdleTimeToClose { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(PhysicalMedium)}: {PhysicalMedium}, {nameof(ComId)}: {ComId}, {nameof(BaudRate)}: {BaudRate}";
}
