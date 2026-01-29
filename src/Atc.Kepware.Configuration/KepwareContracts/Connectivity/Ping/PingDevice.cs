namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Ping;

/// <summary>
/// Represents a Ping device.
/// </summary>
internal sealed class PingDevice : DeviceBase, IPingDevice
{
    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}";
}