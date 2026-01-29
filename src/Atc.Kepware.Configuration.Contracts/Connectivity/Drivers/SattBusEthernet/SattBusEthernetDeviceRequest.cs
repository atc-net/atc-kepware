namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SattBusEthernet;

/// <summary>
/// Represents a SattBus Ethernet device creation request.
/// </summary>
public class SattBusEthernetDeviceRequest : DeviceRequestBase, ISattBusEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SattBusEthernetDeviceRequest"/> class.
    /// </summary>
    public SattBusEthernetDeviceRequest()
        : base(DriverType.SattBusEthernet)
    {
    }

    /// <summary>
    /// Gets or sets the device IP address.
    /// </summary>
    /// <remarks>
    /// Format: IP.Address (e.g., "192.168.1.1").
    /// </remarks>
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 2999;

    /// <inheritdoc />
    public SattBusEthernetIpProtocolType IpProtocol { get; set; } = SattBusEthernetIpProtocolType.Udp;

    /// <inheritdoc />
    public bool OverlappedAddressing { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int WriteToPort { get; set; } = 2999;

    /// <inheritdoc />
    public SattBusEthernetBitOrderingType BitOrdering { get; set; } = SattBusEthernetBitOrderingType.MsBit15To0;

    /// <inheritdoc />
    public SattBusEthernetRegisterBlockSizeType RegisterBlockSize { get; set; } = SattBusEthernetRegisterBlockSizeType.Bytes20;

    /// <inheritdoc />
    public SattBusEthernetIoRamMemoryCellBlockSizeType IoRamMemoryCellBlockSize { get; set; } = SattBusEthernetIoRamMemoryCellBlockSizeType.Bytes20;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PortNumber)}: {PortNumber}, {nameof(IpProtocol)}: {IpProtocol}, {nameof(OverlappedAddressing)}: {OverlappedAddressing}, {nameof(WriteToPort)}: {WriteToPort}, {nameof(BitOrdering)}: {BitOrdering}, {nameof(RegisterBlockSize)}: {RegisterBlockSize}, {nameof(IoRamMemoryCellBlockSize)}: {IoRamMemoryCellBlockSize}";
}
