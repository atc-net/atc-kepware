namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyControlLogixEthernet;

/// <summary>
/// Device request properties for the Allen-Bradley ControlLogix Ethernet driver.
/// </summary>
public sealed class AllenBradleyControlLogixEthernetDeviceRequest : DeviceRequestBase, IAllenBradleyControlLogixEthernetDeviceRequest
{
    public AllenBradleyControlLogixEthernetDeviceRequest()
        : base(DriverType.AllenBradleyControlLogixEthernet)
    {
    }

    /// <inheritdoc />
    public ControlLogixDeviceModelType Model { get; set; } = ControlLogixDeviceModelType.ControlLogix5500;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 44818;

    /// <inheritdoc />
    [Range(500, 4000)]
    public int ConnectionSizeBytes { get; set; } = 500;

    /// <inheritdoc />
    public ControlLogixInactivityWatchdogType InactivityWatchdog { get; set; } = ControlLogixInactivityWatchdogType.Seconds32;

    /// <inheritdoc />
    public ControlLogixArrayBlockSizeType ArrayBlockSize { get; set; } = ControlLogixArrayBlockSizeType.Elements120;

    /// <inheritdoc />
    public ControlLogixProtocolModeType ProtocolMode { get; set; } = ControlLogixProtocolModeType.LogicalNonBlocking;

    /// <inheritdoc />
    public bool SynchronizeAfterOnlineEdits { get; set; } = true;

    /// <inheritdoc />
    public bool SynchronizeAfterOfflineEdits { get; set; } = true;

    /// <inheritdoc />
    public bool TerminateStringDataAtLen { get; set; } = true;

    /// <inheritdoc />
    public ControlLogixDefaultDataType DefaultDataType { get; set; } = ControlLogixDefaultDataType.Default;

    /// <inheritdoc />
    public bool PerformanceStatistics { get; set; }

    /// <inheritdoc />
    public ControlLogixDatabaseImportMethodType DatabaseImportMethod { get; set; } = ControlLogixDatabaseImportMethodType.CreateFromDevice;

    /// <inheritdoc />
    [MaxLength(1024)]
    public string? TagImportFile { get; set; }

    /// <inheritdoc />
    public bool TagDescriptions { get; set; } = true;

    /// <inheritdoc />
    public bool LimitNameLength { get; set; }

    /// <inheritdoc />
    public ControlLogixTagHierarchyType TagHierarchy { get; set; } = ControlLogixTagHierarchyType.Expanded;

    /// <inheritdoc />
    public bool ImposeArrayLimit { get; set; }

    /// <inheritdoc />
    [Range(1, 65536)]
    public int ArrayCountUpperLimit { get; set; } = 2000;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
