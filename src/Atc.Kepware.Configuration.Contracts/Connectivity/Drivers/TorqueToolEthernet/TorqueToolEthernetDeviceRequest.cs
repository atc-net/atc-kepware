namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.TorqueToolEthernet;

/// <summary>
/// Device properties for the Torque Tool Ethernet driver.
/// </summary>
public sealed class TorqueToolEthernetDeviceRequest : DeviceRequestBase, ITorqueToolEthernetDeviceRequest
{
    public TorqueToolEthernetDeviceRequest()
        : base(DriverType.TorqueToolEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 4545;

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
    public bool SetErrorStateForAllDnrs { get; set; }

    /// <inheritdoc />
    [Range(1, 15)]
    public int PollTimeSeconds { get; set; } = 10;

    /// <inheritdoc />
    [Range(100, 30000)]
    public int ReplyTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int Retries { get; set; } = 3;

    /// <inheritdoc />
    [Range(0, 3)]
    public int AlarmRevision { get; set; }

    /// <inheritdoc />
    [Range(0, 6)]
    public int CommunicationRevision { get; set; }

    /// <inheritdoc />
    [Range(0, 3)]
    public int JobDataRevision { get; set; }

    /// <inheritdoc />
    [Range(0, 4)]
    public int JobInfoRevision { get; set; }

    /// <inheritdoc />
    [Range(0, 2)]
    public int JobStateRevision { get; set; }

    /// <inheritdoc />
    public int LastTighteningRevision { get; set; }

    /// <inheritdoc />
    [Range(0, 7)]
    public int OldTighteningRevision { get; set; }

    /// <inheritdoc />
    [Range(0, 2)]
    public int SelectorLightsRevision { get; set; }

    /// <inheritdoc />
    [Range(0, 5)]
    public int ToolDataRevision { get; set; }

    /// <inheritdoc />
    [Range(0, 2)]
    public int VinRevision { get; set; }

    /// <inheritdoc />
    public bool DisableToolOnLtr { get; set; }

    /// <inheritdoc />
    public TorqueToolEthernetRevisionFormat RevisionFormat { get; set; } = TorqueToolEthernetRevisionFormat.Empty;

    /// <inheritdoc />
    public bool UseGenericSubscribe { get; set; }

    /// <inheritdoc />
    public bool UseUnsolicitedDataPacking { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}