namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FanucFocasEthernet;

/// <summary>
/// Device properties for the Fanuc Focas Ethernet driver.
/// </summary>
public sealed class FanucFocasEthernetDeviceRequest : DeviceRequestBase, IFanucFocasEthernetDeviceRequest
{
    public FanucFocasEthernetDeviceRequest()
        : base(DriverType.FanucFocasEthernet)
    {
    }

    /// <inheritdoc />
    public FanucFocasDeviceModelType Model { get; set; } = FanucFocasDeviceModelType.Series16i;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int RetryAttempts { get; set; } = 3;

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
    [Range(0, 65535)]
    public int Port { get; set; } = 8193;

    /// <inheritdoc />
    public FanucFocasMaximumRequestSizeType MaximumRequestSize { get; set; } = FanucFocasMaximumRequestSizeType.Bytes256;

    /// <inheritdoc />
    public bool FanucFocasServerDevice { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    public int UnsolicitedMessageServerPort { get; set; } = 8196;

    /// <inheritdoc />
    public FanucFocasTransferControlMemoryType TransferControlMemoryType { get; set; } = FanucFocasTransferControlMemoryType.R;

    /// <inheritdoc />
    [Range(0, 7999)]
    public int TransferControlStartAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 10)]
    public int MessageRetries { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 30)]
    public int MessageTimeoutSeconds { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 30)]
    public int MessageAliveTimeSeconds { get; set; } = 5;

    /// <inheritdoc />
    public bool DataArea1Enable { get; set; }

    /// <inheritdoc />
    public FanucFocasPmcAddressType DataArea1PmcAddressType { get; set; } = FanucFocasPmcAddressType.D;

    /// <inheritdoc />
    [Range(0, 7999)]
    public int DataArea1StartAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 7999)]
    public int DataArea1EndAddress { get; set; }

    /// <inheritdoc />
    public bool DataArea2Enable { get; set; }

    /// <inheritdoc />
    public FanucFocasPmcAddressType DataArea2PmcAddressType { get; set; } = FanucFocasPmcAddressType.D;

    /// <inheritdoc />
    [Range(0, 7999)]
    public int DataArea2StartAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 7999)]
    public int DataArea2EndAddress { get; set; }

    /// <inheritdoc />
    public bool DataArea3Enable { get; set; }

    /// <inheritdoc />
    public FanucFocasPmcAddressType DataArea3PmcAddressType { get; set; } = FanucFocasPmcAddressType.D;

    /// <inheritdoc />
    [Range(0, 7999)]
    public int DataArea3StartAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 7999)]
    public int DataArea3EndAddress { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}