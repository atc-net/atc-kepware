namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity;

public interface IChannelBase
{
    /// <summary>
    /// Name of the channel.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Description of the channel.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Specifies the device driver.
    /// </summary>
    string DeviceDriver { get; set; }

    /// <summary>
    /// Select whether or not to make the channel's diagnostic information available to an OPC application.
    /// </summary>
    bool? CaptureDiagnostics { get; set; }

    /// <summary>
    /// The total number of user defined tags assigned to the channel and all of its devices.
    /// </summary>
    int TagCount { get; set; }

    /// <summary>
    /// Choose how write data is passed to the underlying communications driver when more than one write exists in the write queue.
    /// </summary>
    ChannelOptimizationMethodType OptimizationMethod { get; set; }

    /// <summary>
    /// Specify the ratio of write operations to read operations, based on one read per configurable number of writes.
    /// </summary>
    int WriteOptimizationDutyCycle { get; set; }

    /// <summary>
    /// Choose how to send invalid floating-point numbers to the client.
    /// </summary>
    ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; }
}