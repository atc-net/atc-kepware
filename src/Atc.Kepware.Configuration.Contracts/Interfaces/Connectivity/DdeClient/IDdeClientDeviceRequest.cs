namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.DdeClient;

/// <summary>
/// Device request properties for the DDE Client driver.
/// </summary>
public interface IDdeClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// The amount of time, in seconds, the driver waits for a link's initial update
    /// before issuing an explicit request.
    /// </summary>
    int InitialUpdateRequestDelaySeconds { get; set; }

    /// <summary>
    /// The amount of time, in seconds, that the driver waits before checking whether
    /// all DDE links have received a data update. A value of zero disables the link check.
    /// </summary>
    int DdeServerCheckIntervalSeconds { get; set; }
}
