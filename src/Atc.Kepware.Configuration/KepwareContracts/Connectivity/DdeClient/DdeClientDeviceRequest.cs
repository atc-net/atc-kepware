namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.DdeClient;

/// <summary>
/// Device request properties for the DDE Client driver.
/// </summary>
internal sealed class DdeClientDeviceRequest : DeviceRequestBase, IDdeClientDeviceRequest
{
    public DdeClientDeviceRequest()
        : base(DriverType.DdeClient)
    {
    }

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("ddeclient.DEVICE_INITIAL_UPDATE_REQUEST_DELAY_SECONDS")]
    public int InitialUpdateRequestDelaySeconds { get; set; } = 5;

    /// <inheritdoc />
    [Range(0, 300)]
    [JsonPropertyName("ddeclient.DEVICE_DDE_SERVER_CHECK_INTERVAL_SECONDS")]
    public int DdeServerCheckIntervalSeconds { get; set; } = 15;

    public override string ToString()
        => $"{base.ToString()}, {nameof(InitialUpdateRequestDelaySeconds)}: {InitialUpdateRequestDelaySeconds}, {nameof(DdeServerCheckIntervalSeconds)}: {DdeServerCheckIntervalSeconds}";
}