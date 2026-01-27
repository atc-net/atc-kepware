namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AllenBradleyMicro800Ethernet;

/// <summary>
/// Device request properties for the Allen-Bradley Micro800 Ethernet driver.
/// </summary>
internal sealed class AllenBradleyMicro800EthernetDeviceRequest : DeviceRequestBase, IAllenBradleyMicro800EthernetDeviceRequest
{
    public AllenBradleyMicro800EthernetDeviceRequest()
        : base(DriverType.AllenBradleyMicro800Ethernet)
    {
    }

    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("allenbradley_micro800_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 44818;

    [JsonPropertyName("allenbradley_micro800_ethernet.DEVICE_INACTIVITY_WATCHDOG_SECONDS")]
    public Micro800InactivityWatchdogType InactivityWatchdog { get; set; } = Micro800InactivityWatchdogType.Seconds32;

    [JsonPropertyName("allenbradley_micro800_ethernet.DEVICE_DEFAULT_DATA_TYPE")]
    public Micro800DefaultDataType DefaultDataType { get; set; } = Micro800DefaultDataType.Float;

    [JsonPropertyName("allenbradley_micro800_ethernet.DEVICE_ARRAY_BLOCK_SIZE_ELEMENTS")]
    public int ArrayBlockSize { get; set; } = 120;

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(InactivityWatchdog)}: {InactivityWatchdog}, {nameof(DefaultDataType)}: {DefaultDataType}, {nameof(ArrayBlockSize)}: {ArrayBlockSize}";
}
