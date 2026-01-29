namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.TorqueToolEthernet;

/// <summary>
/// Torque Tool Ethernet device - Kepware format.
/// </summary>
internal sealed class TorqueToolEthernetDevice : DeviceBase, ITorqueToolEthernetDevice
{
    [JsonPropertyName("servermain.DEVICE_ID_STRING")]
    public string DeviceId { get; set; } = string.Empty;

    [JsonPropertyName("torque_tool_ethernet.DEVICE_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("servermain.DEVICE_CONNECTION_TIMEOUT_SECONDS")]
    public int ConnectTimeoutSeconds { get; set; }

    [JsonPropertyName("servermain.DEVICE_REQUEST_TIMEOUT_MILLISECONDS")]
    public int RequestTimeoutMs { get; set; }

    [JsonPropertyName("servermain.DEVICE_RETRY_ATTEMPTS")]
    public int RetryAttempts { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_SET_ERROR_FOR_DNR")]
    public bool SetErrorStateForAllDnrs { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_POLL_TIME_SEC")]
    public int PollTimeSeconds { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_REPLY_TIMEOUT_MS")]
    public int ReplyTimeoutMs { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_FAIL_AFTER")]
    public int Retries { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_ALARM_REV")]
    public int AlarmRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_COMMUNICATION_REV")]
    public int CommunicationRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_JOB_DATA")]
    public int JobDataRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_JOB_INFO")]
    public int JobInfoRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_JOB_STATE")]
    public int JobStateRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_LAST_TIGHTENING")]
    public int LastTighteningRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_OLD_TIGHTENING")]
    public int OldTighteningRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_SELECTOR_LIGHTS_REV")]
    public int SelectorLightsRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_TOOL_DATA_REV")]
    public int ToolDataRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_VIN")]
    public int VinRevision { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_DISABLE_TOOL_ON_LTR")]
    public bool DisableToolOnLtr { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_REVISION_FORMAT")]
    public TorqueToolEthernetRevisionFormat RevisionFormat { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_USE_GENERIC_SUBSCRIBE")]
    public bool UseGenericSubscribe { get; set; }

    [JsonPropertyName("torque_tool_ethernet.DEVICE_USE_UNSOLICITED_DATA_PACKING")]
    public bool UseUnsolicitedDataPacking { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}