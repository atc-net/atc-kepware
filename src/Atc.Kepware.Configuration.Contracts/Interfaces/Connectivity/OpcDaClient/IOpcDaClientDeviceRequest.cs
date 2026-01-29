namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OpcDaClient;

/// <summary>
/// Defines the OPC DA Client device request properties.
/// </summary>
public interface IOpcDaClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets an optional name for identifying the group.
    /// </summary>
    /// <remarks>
    /// If empty, the underlying OPC server generates a unique name.
    /// </remarks>
    string? GroupName { get; set; }

    /// <summary>
    /// Gets or sets the update mode.
    /// </summary>
    OpcDaClientUpdateMode UpdateMode { get; set; }

    /// <summary>
    /// Gets or sets the data update rate in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-3600000 ms.
    /// </remarks>
    int UpdatePollRate { get; set; }

    /// <summary>
    /// Gets or sets the percent change in data required to notify the client.
    /// </summary>
    /// <remarks>
    /// Only used in Exception mode. Valid range: 0-100.
    /// </remarks>
    float PercentDeadband { get; set; }

    /// <summary>
    /// Gets or sets the language ID for text operations.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65535. Default is 1033 (English).
    /// </remarks>
    int LanguageId { get; set; }

    /// <summary>
    /// Gets or sets the write method.
    /// </summary>
    OpcDaClientReadWriteMethod WriteMethod { get; set; }

    /// <summary>
    /// Gets or sets the read method.
    /// </summary>
    /// <remarks>
    /// Only applicable in Poll mode.
    /// </remarks>
    OpcDaClientReadWriteMethod ReadMethod { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of items per read request.
    /// </summary>
    /// <remarks>
    /// Only applicable in Poll mode. Valid range: 1-512.
    /// </remarks>
    int MaxItemsPerRead { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of items per write request.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-512.
    /// </remarks>
    int MaxItemsPerWrite { get; set; }

    /// <summary>
    /// Gets or sets the read timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Only applicable in Poll mode. Valid range: 100-30000 ms.
    /// </remarks>
    int ReadTimeout { get; set; }

    /// <summary>
    /// Gets or sets the write timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 100-30000 ms.
    /// </remarks>
    int WriteTimeout { get; set; }

    /// <summary>
    /// Gets or sets whether to perform a read after writes.
    /// </summary>
    bool ReadAfterWrite { get; set; }

    /// <summary>
    /// Gets or sets whether to use the watchdog callback monitoring feature.
    /// </summary>
    /// <remarks>
    /// Only applicable in Exception mode.
    /// </remarks>
    bool Watchdog { get; set; }

    /// <summary>
    /// Gets or sets the Item ID of the watchdog tag.
    /// </summary>
    /// <remarks>
    /// Only used when Watchdog is enabled.
    /// </remarks>
    string? WatchdogItemId { get; set; }

    /// <summary>
    /// Gets or sets the number of missed updates before reconnecting.
    /// </summary>
    /// <remarks>
    /// Only used when Watchdog is enabled. Valid range: 2-10.
    /// </remarks>
    int MissedUpdatesBeforeReconnect { get; set; }
}