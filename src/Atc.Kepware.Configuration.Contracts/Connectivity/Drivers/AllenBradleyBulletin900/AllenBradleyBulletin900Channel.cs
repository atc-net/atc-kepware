namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyBulletin900;

/// <summary>
/// Channel properties for the Allen-Bradley Bulletin 900 driver (response).
/// </summary>
public sealed class AllenBradleyBulletin900Channel : ChannelBase
{
    /// <summary>
    /// Select the hardware device type for data communications (or None).
    /// </summary>
    public Bulletin900SerialPhysicalMediumType PhysicalMedium { get; set; }

    /// <summary>
    /// Select what occurs when an explicit device read is requested.
    /// </summary>
    public Bulletin900SerialReadProcessingType? ReadProcessing { get; set; }

    /// <summary>
    /// Specify the physical COM port number.
    /// </summary>
    public int? ComId { get; set; }

    /// <summary>
    /// Select the communications speed of the hardware in bits per second.
    /// </summary>
    public Bulletin900BaudRateType? BaudRate { get; set; }

    /// <summary>
    /// Select the number of data bits per word.
    /// </summary>
    public Bulletin900DataBitsType? DataBits { get; set; }

    /// <summary>
    /// Indicate if the data parity for this communication is Odd, Even, or None.
    /// </summary>
    public Bulletin900ParityType? Parity { get; set; }

    /// <summary>
    /// Specify the number of stop bits that indicate the end of a data transmission.
    /// </summary>
    public Bulletin900StopBitsType? StopBits { get; set; }

    /// <summary>
    /// Select the Flow Control required by the target device.
    /// </summary>
    public Bulletin900FlowControlType? FlowControl { get; set; }

    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    public string? NetworkAdapter { get; set; }

    /// <summary>
    /// Choose whether or not low-level communication errors are posted to the event log.
    /// </summary>
    public bool? ReportCommunicationErrors { get; set; }

    /// <summary>
    /// Choose whether or not COM port connections are terminated when inactive.
    /// </summary>
    public bool? CloseIdleConnection { get; set; }

    /// <summary>
    /// Define the time, in seconds, a connection can be inactive before being terminated.
    /// </summary>
    public int? IdleTimeToClose { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PhysicalMedium)}: {PhysicalMedium}, {nameof(ComId)}: {ComId}, {nameof(BaudRate)}: {BaudRate}";
}
