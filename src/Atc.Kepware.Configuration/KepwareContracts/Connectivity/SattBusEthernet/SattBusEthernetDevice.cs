namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SattBusEthernet;

/// <summary>
/// Device properties for the SattBus Ethernet driver.
/// </summary>
internal sealed class SattBusEthernetDevice : DeviceBase, ISattBusEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("sattbus_ethernet.DEVICE_PORT_NUMBER_LOCAL")]
    public int PortNumber { get; set; }

    [JsonPropertyName("sattbus_ethernet.DEVICE_IP_PROTOCOL")]
    public SattBusEthernetIpProtocolType IpProtocol { get; set; }

    [JsonPropertyName("sattbus_ethernet.DEVICE_OVERLAPPED_ADDRESSING")]
    public bool OverlappedAddressing { get; set; }

    [JsonPropertyName("sattbus_ethernet.DEVICE_PORT_NUMBER_WRITE_TO")]
    public int WriteToPort { get; set; }

    [JsonPropertyName("sattbus_ethernet.DEVICE_BIT_ORDERING")]
    public SattBusEthernetBitOrderingType BitOrdering { get; set; }

    [JsonPropertyName("sattbus_ethernet.DEVICE_REGISTER_BLOCK_SIZE")]
    public SattBusEthernetRegisterBlockSizeType RegisterBlockSize { get; set; }

    [JsonPropertyName("sattbus_ethernet.DEVICE_IO_RAM_MEMORY_CELL_BLOCK_SIZE")]
    public SattBusEthernetIoRamMemoryCellBlockSizeType IoRamMemoryCellBlockSize { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(IpProtocol)}: {IpProtocol}, {nameof(OverlappedAddressing)}: {OverlappedAddressing}, {nameof(WriteToPort)}: {WriteToPort}, {nameof(BitOrdering)}: {BitOrdering}, {nameof(RegisterBlockSize)}: {RegisterBlockSize}, {nameof(IoRamMemoryCellBlockSize)}: {IoRamMemoryCellBlockSize}";
}
