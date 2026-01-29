namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ModbusTcpIpEthernet;

/// <summary>
/// Device properties for the Modbus TCP/IP Ethernet driver.
/// </summary>
public sealed class ModbusTcpIpEthernetDeviceRequest : DeviceRequestBase, IModbusTcpIpEthernetDeviceRequest
{
    public ModbusTcpIpEthernetDeviceRequest()
        : base(DriverType.ModbusTcpIpEthernet)
    {
    }

    /// <inheritdoc />
    public ModbusDeviceModelType Model { get; set; } = ModbusDeviceModelType.Modbus;

    /// <inheritdoc />
    public ModbusDeviceIdFormatType IdFormat { get; set; } = ModbusDeviceIdFormatType.Decimal;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(10, 9999999)]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 30000)]
    public int InterRequestDelayMs { get; set; }

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public ModbusDeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = ModbusDeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

    /// <inheritdoc />
    public ModbusDeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = ModbusDeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    public ModbusDeviceIpProtocolType IpProtocol { get; set; } = ModbusDeviceIpProtocolType.TcpIp;

    /// <inheritdoc />
    public bool CloseSocketOnTimeout { get; set; } = true;

    /// <inheritdoc />
    public bool ZeroBasedAddressing { get; set; } = true;

    /// <inheritdoc />
    public bool ZeroBasedBitAddressing { get; set; } = true;

    /// <inheritdoc />
    public bool HoldingRegisterBitMaskWrites { get; set; } = true;

    /// <inheritdoc />
    public bool ModbusFunction06 { get; set; } = true;

    /// <inheritdoc />
    public bool ModbusFunction05 { get; set; } = true;

    /// <inheritdoc />
    public bool ModbusByteOrder { get; set; } = true;

    /// <inheritdoc />
    public bool FirstWordLow { get; set; } = true;

    /// <inheritdoc />
    public bool FirstDWordLow { get; set; } = true;

    /// <inheritdoc />
    public bool ModiconBitOrder { get; set; }

    /// <inheritdoc />
    public bool TreatLongsAsDoubleDecimal { get; set; }

    /// <inheritdoc />
    [Range(8, 2000)]
    public int OutputCoilsBlockSize { get; set; } = 32;

    /// <inheritdoc />
    [Range(8, 2000)]
    public int InputCoilsBlockSize { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int InternalRegistersBlockSize { get; set; } = 32;

    /// <inheritdoc />
    [Range(1, 120)]
    public int HoldingRegistersBlockSize { get; set; } = 32;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(IpProtocol)}: {IpProtocol}";
}