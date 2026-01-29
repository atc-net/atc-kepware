namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcDaClient;

/// <summary>
/// Represents an OPC DA Client device.
/// </summary>
public class OpcDaClientDevice : DeviceBase, IOpcDaClientDevice
{
    /// <inheritdoc />
    public string? GroupName { get; set; }

    /// <inheritdoc />
    public OpcDaClientUpdateMode UpdateMode { get; set; } = OpcDaClientUpdateMode.Exception;

    /// <inheritdoc />
    public int UpdatePollRate { get; set; } = 1000;

    /// <inheritdoc />
    public float PercentDeadband { get; set; }

    /// <inheritdoc />
    public int LanguageId { get; set; } = 1033;

    /// <inheritdoc />
    public OpcDaClientReadWriteMethod WriteMethod { get; set; } = OpcDaClientReadWriteMethod.Asynchronous;

    /// <inheritdoc />
    public OpcDaClientReadWriteMethod ReadMethod { get; set; } = OpcDaClientReadWriteMethod.Asynchronous;

    /// <inheritdoc />
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    public int ReadTimeout { get; set; } = 1000;

    /// <inheritdoc />
    public int WriteTimeout { get; set; } = 1000;

    /// <inheritdoc />
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    public bool Watchdog { get; set; }

    /// <inheritdoc />
    public string? WatchdogItemId { get; set; }

    /// <inheritdoc />
    public int MissedUpdatesBeforeReconnect { get; set; } = 3;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(UpdatePollRate)}: {UpdatePollRate}";
}