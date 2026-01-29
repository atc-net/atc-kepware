namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Ping;

/// <summary>
/// Represents a Ping device creation request.
/// </summary>
internal sealed class PingDeviceRequest : DeviceRequestBase, IPingDeviceRequest
{
    public PingDeviceRequest()
        : base(DriverType.Ping)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}";
}
