namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ModbusTcpIpEthernet;

public sealed class ModbusTcpIpEthernetDevice : DeviceBase, IModbusTcpIpEthernetDevice
{
    /// <inheritdoc />
    public ModbusDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public ModbusDeviceIdFormatType IdFormat { get; set; }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public int InterRequestDelayMs { get; set; }

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    public int TimeoutsToDemote { get; set; }

    /// <inheritdoc />
    public int DemotionPeriodMs { get; set; }

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public ModbusDeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <inheritdoc />
    public ModbusDeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <inheritdoc />
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <inheritdoc />
    public int Port { get; set; }

    /// <inheritdoc />
    public ModbusDeviceIpProtocolType IpProtocol { get; set; }

    /// <inheritdoc />
    public bool CloseSocketOnTimeout { get; set; }

    /// <inheritdoc />
    public bool ZeroBasedAddressing { get; set; }

    /// <inheritdoc />
    public bool ZeroBasedBitAddressing { get; set; }

    /// <inheritdoc />
    public bool HoldingRegisterBitMaskWrites { get; set; }

    /// <inheritdoc />
    public bool ModbusFunction06 { get; set; }

    /// <inheritdoc />
    public bool ModbusFunction05 { get; set; }

    /// <inheritdoc />
    public bool ModbusByteOrder { get; set; }

    /// <inheritdoc />
    public bool FirstWordLow { get; set; }

    /// <inheritdoc />
    public bool FirstDWordLow { get; set; }

    /// <inheritdoc />
    public bool ModiconBitOrder { get; set; }

    /// <inheritdoc />
    public bool TreatLongsAsDoubleDecimal { get; set; }

    /// <inheritdoc />
    public int OutputCoilsBlockSize { get; set; }

    /// <inheritdoc />
    public int InputCoilsBlockSize { get; set; }

    /// <inheritdoc />
    public int InternalRegistersBlockSize { get; set; }

    /// <inheritdoc />
    public int HoldingRegistersBlockSize { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(IdFormat)}: {IdFormat}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}, {nameof(IpProtocol)}: {IpProtocol}";
}
