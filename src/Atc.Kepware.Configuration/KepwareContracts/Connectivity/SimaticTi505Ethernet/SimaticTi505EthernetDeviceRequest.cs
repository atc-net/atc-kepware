namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SimaticTi505Ethernet;

/// <summary>
/// Simatic/TI 505 Ethernet device request - Kepware format.
/// </summary>
internal sealed class SimaticTi505EthernetDeviceRequest : DeviceRequestBase, ISimaticTi505EthernetDeviceRequest
{
    public SimaticTi505EthernetDeviceRequest()
        : base(DriverType.SimaticTi505Ethernet)
    {
    }

    [JsonPropertyName("simatic505_ethernet.DEVICE_IP_PROTOCOL")]
    public SimaticTi505EthernetIpProtocol IpProtocol { get; set; } = SimaticTi505EthernetIpProtocol.Udp;

    [JsonPropertyName("simatic505_ethernet.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 1505;

    [JsonPropertyName("simatic505_ethernet.DEVICE_REQUEST_SIZE")]
    public SimaticTi505EthernetRequestSize RequestSize { get; set; } = SimaticTi505EthernetRequestSize.Bytes250;

    [JsonPropertyName("simatic505_ethernet.DEVICE_505_PROTOCOL")]
    public SimaticTi505EthernetProtocol Protocol { get; set; } = SimaticTi505EthernetProtocol.CampPlusPackedTaskCode;

    [JsonPropertyName("simatic505_ethernet.DEVICE_TI565")]
    public bool Ti565 { get; set; }

    [JsonPropertyName("simatic505_ethernet.DEVICE_ZERO_ONE_BASED_ADDRESSING")]
    public SimaticTi505EthernetBitAddressing BitAddressing { get; set; } = SimaticTi505EthernetBitAddressing.ZeroBased;

    [JsonPropertyName("simatic505_ethernet.DEVICE_BIT_ORDER_FOR_LOOPS_AND_ALARMS")]
    public SimaticTi505EthernetBitOrder BitOrderForLoopsAndAlarms { get; set; } = SimaticTi505EthernetBitOrder.Bit01IsLsb;

    [JsonPropertyName("simatic505_ethernet.DEVICE_BIT_ORDER_V_K_WX_WY_STW")]
    public SimaticTi505EthernetBitOrder BitOrderVKWxWyStw { get; set; } = SimaticTi505EthernetBitOrder.Bit01IsLsb;

    public override string ToString()
        => $"{base.ToString()}, {nameof(IpProtocol)}: {IpProtocol}, {nameof(PortNumber)}: {PortNumber}, {nameof(RequestSize)}: {RequestSize}, {nameof(Protocol)}: {Protocol}, {nameof(Ti565)}: {Ti565}, {nameof(BitAddressing)}: {BitAddressing}, {nameof(BitOrderForLoopsAndAlarms)}: {BitOrderForLoopsAndAlarms}, {nameof(BitOrderVKWxWyStw)}: {BitOrderVKWxWyStw}";
}
