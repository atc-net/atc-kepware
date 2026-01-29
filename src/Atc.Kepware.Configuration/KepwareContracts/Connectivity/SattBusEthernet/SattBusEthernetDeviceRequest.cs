namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SattBusEthernet;

/// <summary>
/// Device request properties for the SattBus Ethernet driver.
/// </summary>
internal sealed class SattBusEthernetDeviceRequest : DeviceRequestBase, ISattBusEthernetDeviceRequest
{
    public SattBusEthernetDeviceRequest()
        : base(DriverType.SattBusEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("sattbus_ethernet.DEVICE_PORT_NUMBER_LOCAL")]
    public int PortNumber { get; set; } = 2999;

    /// <inheritdoc />
    [JsonPropertyName("sattbus_ethernet.DEVICE_IP_PROTOCOL")]
    public SattBusEthernetIpProtocolType IpProtocol { get; set; } = SattBusEthernetIpProtocolType.Udp;

    /// <inheritdoc />
    [JsonPropertyName("sattbus_ethernet.DEVICE_OVERLAPPED_ADDRESSING")]
    public bool OverlappedAddressing { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("sattbus_ethernet.DEVICE_PORT_NUMBER_WRITE_TO")]
    public int WriteToPort { get; set; } = 2999;

    /// <inheritdoc />
    [JsonPropertyName("sattbus_ethernet.DEVICE_BIT_ORDERING")]
    public SattBusEthernetBitOrderingType BitOrdering { get; set; } = SattBusEthernetBitOrderingType.MsBit15To0;

    /// <inheritdoc />
    [JsonPropertyName("sattbus_ethernet.DEVICE_REGISTER_BLOCK_SIZE")]
    public SattBusEthernetRegisterBlockSizeType RegisterBlockSize { get; set; } = SattBusEthernetRegisterBlockSizeType.Bytes20;

    /// <inheritdoc />
    [JsonPropertyName("sattbus_ethernet.DEVICE_IO_RAM_MEMORY_CELL_BLOCK_SIZE")]
    public SattBusEthernetIoRamMemoryCellBlockSizeType IoRamMemoryCellBlockSize { get; set; } = SattBusEthernetIoRamMemoryCellBlockSizeType.Bytes20;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(IpProtocol)}: {IpProtocol}, {nameof(OverlappedAddressing)}: {OverlappedAddressing}, {nameof(WriteToPort)}: {WriteToPort}, {nameof(BitOrdering)}: {BitOrdering}, {nameof(RegisterBlockSize)}: {RegisterBlockSize}, {nameof(IoRamMemoryCellBlockSize)}: {IoRamMemoryCellBlockSize}";
}