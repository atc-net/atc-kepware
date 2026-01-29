namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcDaClient;

/// <summary>
/// Represents an OPC DA Client device creation request.
/// </summary>
public class OpcDaClientDeviceRequest : DeviceRequestBase, IOpcDaClientDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpcDaClientDeviceRequest"/> class.
    /// </summary>
    public OpcDaClientDeviceRequest()
        : base(DriverType.OpcDaClient)
    {
    }

    /// <inheritdoc />
    public string? GroupName { get; set; }

    /// <inheritdoc />
    public OpcDaClientUpdateMode UpdateMode { get; set; } = OpcDaClientUpdateMode.Exception;

    /// <inheritdoc />
    [Range(0, 3600000)]
    public int UpdatePollRate { get; set; } = 1000;

    /// <inheritdoc />
    [Range(0, 100)]
    public float PercentDeadband { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    public int LanguageId { get; set; } = 1033;

    /// <inheritdoc />
    public OpcDaClientReadWriteMethod WriteMethod { get; set; } = OpcDaClientReadWriteMethod.Asynchronous;

    /// <inheritdoc />
    public OpcDaClientReadWriteMethod ReadMethod { get; set; } = OpcDaClientReadWriteMethod.Asynchronous;

    /// <inheritdoc />
    [Range(1, 512)]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    [Range(1, 512)]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    [Range(100, 30000)]
    public int ReadTimeout { get; set; } = 1000;

    /// <inheritdoc />
    [Range(100, 30000)]
    public int WriteTimeout { get; set; } = 1000;

    /// <inheritdoc />
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    public bool Watchdog { get; set; }

    /// <inheritdoc />
    public string? WatchdogItemId { get; set; }

    /// <inheritdoc />
    [Range(2, 10)]
    public int MissedUpdatesBeforeReconnect { get; set; } = 3;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(UpdatePollRate)}: {UpdatePollRate}";
}
