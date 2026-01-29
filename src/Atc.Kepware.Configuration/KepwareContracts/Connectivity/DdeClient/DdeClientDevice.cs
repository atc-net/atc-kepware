namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.DdeClient;

/// <summary>
/// Device properties for the DDE Client driver.
/// </summary>
internal sealed class DdeClientDevice : DeviceBase, IDdeClientDevice
{
    /// <inheritdoc />
    [JsonPropertyName("ddeclient.DEVICE_INITIAL_UPDATE_REQUEST_DELAY_SECONDS")]
    public int InitialUpdateRequestDelaySeconds { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("ddeclient.DEVICE_DDE_SERVER_CHECK_INTERVAL_SECONDS")]
    public int DdeServerCheckIntervalSeconds { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(InitialUpdateRequestDelaySeconds)}: {InitialUpdateRequestDelaySeconds}, {nameof(DdeServerCheckIntervalSeconds)}: {DdeServerCheckIntervalSeconds}";
}
