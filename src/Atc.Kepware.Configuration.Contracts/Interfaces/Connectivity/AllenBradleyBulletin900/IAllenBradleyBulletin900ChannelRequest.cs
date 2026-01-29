namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyBulletin900;

/// <summary>
/// Channel request properties for the Allen-Bradley Bulletin 900 driver.
/// </summary>
public interface IAllenBradleyBulletin900ChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Select the hardware device type for data communications (or None).
    /// </summary>
    Bulletin900SerialPhysicalMediumType PhysicalMedium { get; set; }

    /// <summary>
    /// Select what occurs when an explicit device read is requested. Fail provides the client an update indicating failure.
    /// </summary>
    Bulletin900SerialReadProcessingType? ReadProcessing { get; set; }

    /// <summary>
    /// Specify the physical COM port number.
    /// </summary>
    int? ComId { get; set; }

    /// <summary>
    /// Select the communications speed of the hardware in bits per second.
    /// </summary>
    Bulletin900BaudRateType? BaudRate { get; set; }

    /// <summary>
    /// Select the number of data bits per word.
    /// </summary>
    Bulletin900DataBitsType? DataBits { get; set; }

    /// <summary>
    /// Indicate if the data parity for this communication is Odd, Even, or None.
    /// </summary>
    Bulletin900ParityType? Parity { get; set; }

    /// <summary>
    /// Specify the number of stop bits that indicate the end of a data transmission.
    /// </summary>
    Bulletin900StopBitsType? StopBits { get; set; }

    /// <summary>
    /// Select the Flow Control required by the target device (for control line utilization).
    /// </summary>
    Bulletin900FlowControlType? FlowControl { get; set; }

    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Choose whether or not low-level communication errors are posted to the event log.
    /// </summary>
    bool? ReportCommunicationErrors { get; set; }

    /// <summary>
    /// Choose whether or not COM port connections are terminated when inactive.
    /// </summary>
    bool? CloseIdleConnection { get; set; }

    /// <summary>
    /// Define the time, in seconds, a connection can be inactive before being terminated.
    /// </summary>
    int? IdleTimeToClose { get; set; }
}