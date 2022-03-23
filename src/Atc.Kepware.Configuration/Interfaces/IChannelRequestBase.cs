namespace Atc.Kepware.Configuration.Interfaces;

public interface IChannelRequestBase
{
    /// <summary>
    /// Specifies the identity of this object.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Summary of this object or its use.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Specifies the device driver.
    /// </summary>
    string DeviceDriver { get; }

    /// <summary>
    /// Indicates whether or not to make the channel's diagnostic information available to an OPC application.
    /// </summary>
    bool? CaptureDiagnostics { get; set; }

    /// <summary>
    /// Determines how write data is passed to the underlying communications driver when more than one write exists in the write queue.
    /// </summary>
    ChannelOptimizationMethodType OptimizationMethod { get; set; }

    /// <summary>
    /// Specifies the ratio of write operations to read operations, based on one read per configurable number of writes.
    /// </summary>
    int WriteOptimizationDutyCycle { get; set; }

    /// <summary>
    /// Determines how to send invalid floating-point numbers to the client.
    /// </summary>
    ChannelNonNormalizedFloatingPointHandlingType NonNormalizedFloatingPointHandling { get; set; }
}