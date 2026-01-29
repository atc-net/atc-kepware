namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC device - Kepware format.
/// </summary>
internal sealed class AutomationDirectEbcDevice : DeviceBase, IAutomationDirectEbcDevice
{
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public AutomationDirectEbcDeviceModel Model { get; set; } = AutomationDirectEbcDeviceModel.H2;

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    [JsonPropertyName("plcdirect_ebc.DEVICE_USE_LINK_WATCHDOG")]
    public bool UseLinkWatchdog { get; set; }

    [JsonPropertyName("plcdirect_ebc.DEVICE_WATCHDOG_TIMEOUT_MILLISECONDS")]
    public int WatchdogTimeoutMs { get; set; } = 60;

    [JsonPropertyName("plcdirect_ebc.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 28784;

    [JsonPropertyName("plcdirect_ebc.DEVICE_AUTO_TAG_GENERATION_PORT")]
    public int AutoTagGenerationPort { get; set; } = 28784;

    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}