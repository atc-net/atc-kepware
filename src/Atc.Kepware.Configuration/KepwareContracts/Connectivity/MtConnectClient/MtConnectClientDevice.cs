namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MtConnectClient;

/// <summary>
/// Device properties for the MTConnect Client driver.
/// </summary>
internal class MtConnectClientDevice : DeviceBase, IMtConnectClientDevice
{
    [JsonPropertyName("mtconnect_client.DEVICE_ID")]
    public string DeviceId { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}";
}
