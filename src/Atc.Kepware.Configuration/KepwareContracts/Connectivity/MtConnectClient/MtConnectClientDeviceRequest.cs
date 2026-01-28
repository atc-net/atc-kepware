namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MtConnectClient;

/// <summary>
/// Device properties for the MTConnect Client driver.
/// </summary>
internal class MtConnectClientDeviceRequest : DeviceRequestBase, IMtConnectClientDeviceRequest
{
    public MtConnectClientDeviceRequest()
        : base(DriverType.MtConnectClient)
    {
    }

    /// <inheritdoc />
    [MaxLength(256)]
    [JsonPropertyName("mtconnect_client.DEVICE_ID")]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}";
}
