namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FanucFocasEthernet;

/// <summary>
/// Device request properties for the Fanuc Focas Ethernet driver.
/// </summary>
internal sealed class FanucFocasEthernetDeviceRequest : DeviceRequestBase, IFanucFocasEthernetDeviceRequest
{
    public FanucFocasEthernetDeviceRequest()
        : base(DriverType.FanucFocasEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public FanucFocasDeviceModelType Model { get; set; } = FanucFocasDeviceModelType.Series16i;

    /// <inheritdoc />
    [Required]
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_ENABLE_ON_COMMUNICATIONS_FAILURES")]
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DEMOTE_AFTER_SUCCESSIVE_TIMEOUTS")]
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_PERIOD_MS")]
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_AUTO_DEMOTION_DISCARD_WRITES")]
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; } = 8193;

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_MAXIMUM_REQUEST_SIZE")]
    public FanucFocasMaximumRequestSizeType MaximumRequestSize { get; set; } = FanucFocasMaximumRequestSizeType.Bytes256;

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_FANUC_FOCAS_SERVER_DEVICE")]
    public bool FanucFocasServerDevice { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_UNSOLICITED_MESSAGE_SERVER_PORT")]
    public int UnsolicitedMessageServerPort { get; set; } = 8196;

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_TRANSFER_CONTROL_MEMORY_TYPE")]
    public FanucFocasTransferControlMemoryType TransferControlMemoryType { get; set; } = FanucFocasTransferControlMemoryType.R;

    /// <inheritdoc />
    [Range(0, 7999)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_TRANSFER_CONTROL_START_ADDRESS")]
    public int TransferControlStartAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 10)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_MESSAGE_RETRIES")]
    public int MessageRetries { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 30)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_MESSAGE_TIMEOUT_S")]
    public int MessageTimeoutSeconds { get; set; } = 10;

    /// <inheritdoc />
    [Range(0, 30)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_MESSAGE_ALIVE_TIME_S")]
    public int MessageAliveTimeSeconds { get; set; } = 5;

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_1_ENABLE")]
    public bool DataArea1Enable { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_1_PMC_ADDRESS_TYPE")]
    public FanucFocasPmcAddressType DataArea1PmcAddressType { get; set; } = FanucFocasPmcAddressType.D;

    /// <inheritdoc />
    [Range(0, 7999)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_1_START_ADDRESS")]
    public int DataArea1StartAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 7999)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_1_END_ADDRESS")]
    public int DataArea1EndAddress { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_2_ENABLE")]
    public bool DataArea2Enable { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_2_PMC_ADDRESS_TYPE")]
    public FanucFocasPmcAddressType DataArea2PmcAddressType { get; set; } = FanucFocasPmcAddressType.D;

    /// <inheritdoc />
    [Range(0, 7999)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_2_START_ADDRESS")]
    public int DataArea2StartAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 7999)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_2_END_ADDRESS")]
    public int DataArea2EndAddress { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_3_ENABLE")]
    public bool DataArea3Enable { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_3_PMC_ADDRESS_TYPE")]
    public FanucFocasPmcAddressType DataArea3PmcAddressType { get; set; } = FanucFocasPmcAddressType.D;

    /// <inheritdoc />
    [Range(0, 7999)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_3_START_ADDRESS")]
    public int DataArea3StartAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 7999)]
    [JsonPropertyName("ge_focas1_ethernet.DEVICE_DATA_AREA_3_END_ADDRESS")]
    public int DataArea3EndAddress { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
