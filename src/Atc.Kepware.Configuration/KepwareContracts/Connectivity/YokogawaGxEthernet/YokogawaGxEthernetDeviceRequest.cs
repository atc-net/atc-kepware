namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Yokogawa GX Ethernet device request - Kepware format.
/// </summary>
internal sealed class YokogawaGxEthernetDeviceRequest : DeviceRequestBase, IYokogawaGxEthernetDeviceRequest
{
    public YokogawaGxEthernetDeviceRequest()
        : base(DriverType.YokogawaGxEthernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public YokogawaGxEthernetModel Model { get; set; } = YokogawaGxEthernetModel.Gx;

    [JsonPropertyName("yokogawa_gx.DEVICE_AS1_SECURITY_OPTION")]
    public bool As1SecurityOption { get; set; }

    [JsonPropertyName("yokogawa_gx.DEVICE_USERNAME")]
    public string Username { get; set; } = "admin";

    [JsonPropertyName("yokogawa_gx.DEVICE_PASSWORD")]
    public string Password { get; set; } = "0";

    [JsonPropertyName("yokogawa_gx.DEVICE_USER_ID")]
    public string UserId { get; set; } = string.Empty;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(As1SecurityOption)}: {As1SecurityOption}, {nameof(Username)}: {Username}";
}
