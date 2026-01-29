namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FanucFocasEthernet;

/// <summary>
/// Device properties for the Fanuc Focas Ethernet driver.
/// </summary>
public sealed class FanucFocasEthernetDevice : DeviceBase, IFanucFocasEthernetDevice
{
    /// <inheritdoc />
    public FanucFocasDeviceModelType Model { get; set; }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    public int TimeoutsToDemote { get; set; }

    /// <inheritdoc />
    public int DemotionPeriodMs { get; set; }

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public int Port { get; set; }

    /// <inheritdoc />
    public FanucFocasMaximumRequestSizeType MaximumRequestSize { get; set; }

    /// <inheritdoc />
    public bool FanucFocasServerDevice { get; set; }

    /// <inheritdoc />
    public int UnsolicitedMessageServerPort { get; set; }

    /// <inheritdoc />
    public FanucFocasTransferControlMemoryType TransferControlMemoryType { get; set; }

    /// <inheritdoc />
    public int TransferControlStartAddress { get; set; }

    /// <inheritdoc />
    public int MessageRetries { get; set; }

    /// <inheritdoc />
    public int MessageTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int MessageAliveTimeSeconds { get; set; }

    /// <inheritdoc />
    public bool DataArea1Enable { get; set; }

    /// <inheritdoc />
    public FanucFocasPmcAddressType DataArea1PmcAddressType { get; set; }

    /// <inheritdoc />
    public int DataArea1StartAddress { get; set; }

    /// <inheritdoc />
    public int DataArea1EndAddress { get; set; }

    /// <inheritdoc />
    public bool DataArea2Enable { get; set; }

    /// <inheritdoc />
    public FanucFocasPmcAddressType DataArea2PmcAddressType { get; set; }

    /// <inheritdoc />
    public int DataArea2StartAddress { get; set; }

    /// <inheritdoc />
    public int DataArea2EndAddress { get; set; }

    /// <inheritdoc />
    public bool DataArea3Enable { get; set; }

    /// <inheritdoc />
    public FanucFocasPmcAddressType DataArea3PmcAddressType { get; set; }

    /// <inheritdoc />
    public int DataArea3StartAddress { get; set; }

    /// <inheritdoc />
    public int DataArea3EndAddress { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}