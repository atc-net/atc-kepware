namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.DdeClient;

/// <summary>
/// Device request properties for the DDE Client driver.
/// </summary>
public sealed class DdeClientDeviceRequest : DeviceRequestBase, IDdeClientDeviceRequest
{
    public DdeClientDeviceRequest()
        : base(DriverType.DdeClient)
    {
    }

    /// <inheritdoc />
    [Range(1, 30)]
    public int InitialUpdateRequestDelaySeconds { get; set; } = 5;

    /// <inheritdoc />
    [Range(0, 300)]
    public int DdeServerCheckIntervalSeconds { get; set; } = 15;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(InitialUpdateRequestDelaySeconds)}: {InitialUpdateRequestDelaySeconds}, {nameof(DdeServerCheckIntervalSeconds)}: {DdeServerCheckIntervalSeconds}";
}