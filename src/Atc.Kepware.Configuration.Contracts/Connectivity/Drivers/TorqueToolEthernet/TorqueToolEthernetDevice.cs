namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.TorqueToolEthernet;

/// <summary>
/// Torque Tool Ethernet device.
/// </summary>
public sealed class TorqueToolEthernetDevice : DeviceBase, ITorqueToolEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int Port { get; set; }

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public bool SetErrorStateForAllDnrs { get; set; }

    /// <inheritdoc />
    public int PollTimeSeconds { get; set; }

    /// <inheritdoc />
    public int ReplyTimeoutMs { get; set; }

    /// <inheritdoc />
    public int Retries { get; set; }

    /// <inheritdoc />
    public int AlarmRevision { get; set; }

    /// <inheritdoc />
    public int CommunicationRevision { get; set; }

    /// <inheritdoc />
    public int JobDataRevision { get; set; }

    /// <inheritdoc />
    public int JobInfoRevision { get; set; }

    /// <inheritdoc />
    public int JobStateRevision { get; set; }

    /// <inheritdoc />
    public int LastTighteningRevision { get; set; }

    /// <inheritdoc />
    public int OldTighteningRevision { get; set; }

    /// <inheritdoc />
    public int SelectorLightsRevision { get; set; }

    /// <inheritdoc />
    public int ToolDataRevision { get; set; }

    /// <inheritdoc />
    public int VinRevision { get; set; }

    /// <inheritdoc />
    public bool DisableToolOnLtr { get; set; }

    /// <inheritdoc />
    public TorqueToolEthernetRevisionFormat RevisionFormat { get; set; }

    /// <inheritdoc />
    public bool UseGenericSubscribe { get; set; }

    /// <inheritdoc />
    public bool UseUnsolicitedDataPacking { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}