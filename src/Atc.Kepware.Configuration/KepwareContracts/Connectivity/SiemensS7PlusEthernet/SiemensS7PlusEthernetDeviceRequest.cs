namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SiemensS7PlusEthernet;

/// <summary>
/// Device request properties for the Siemens S7 Plus Ethernet driver.
/// </summary>
internal sealed class SiemensS7PlusEthernetDeviceRequest : DeviceRequestBase, ISiemensS7PlusEthernetDeviceRequest
{
    public SiemensS7PlusEthernetDeviceRequest()
        : base(DriverType.SiemensS7PlusEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 65535)]
    [JsonPropertyName("siemens_s7_plus_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 102;

    /// <inheritdoc />
    [JsonPropertyName("siemens_s7_plus_ethernet.DEVICE_PLC_PASSWORD")]
    public string? PlcPassword { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("siemens_s7_plus_ethernet.DEVICE_INCLUDE_IDBS_FBS")]
    public bool IncludeIdbsFbs { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
