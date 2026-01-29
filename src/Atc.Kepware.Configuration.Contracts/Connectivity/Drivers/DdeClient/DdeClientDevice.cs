namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.DdeClient;

/// <summary>
/// Device properties for the DDE Client driver.
/// </summary>
public sealed class DdeClientDevice : DeviceBase, IDdeClientDevice
{
    /// <inheritdoc />
    public int InitialUpdateRequestDelaySeconds { get; set; }

    /// <inheritdoc />
    public int DdeServerCheckIntervalSeconds { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(InitialUpdateRequestDelaySeconds)}: {InitialUpdateRequestDelaySeconds}, {nameof(DdeServerCheckIntervalSeconds)}: {DdeServerCheckIntervalSeconds}";
}