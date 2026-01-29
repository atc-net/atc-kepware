namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OpcXmlDaClient;

/// <summary>
/// Defines the OPC XML-DA Client device request properties.
/// </summary>
public interface IOpcXmlDaClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the update mode.
    /// </summary>
    /// <remarks>
    /// In Exception Mode, the driver creates a subscription to tags and receives updates from the server when the data changes.
    /// Poll Mode polls the remote server for data at the rate specified by the Update/Poll Rate.
    /// </remarks>
    OpcXmlDaClientUpdateMode UpdateMode { get; set; }

    /// <summary>
    /// Gets or sets the update/poll rate in milliseconds.
    /// </summary>
    /// <remarks>
    /// Specifies the rate at which data should be updated.
    /// In Exception Mode, this specifies how frequently the remote server provides updates for changed data.
    /// In Poll Mode, this specifies how frequently the driver reads data from the remote server.
    /// Valid range: 100-3600000 ms.
    /// </remarks>
    int UpdatePollRate { get; set; }

    /// <summary>
    /// Gets or sets the language ID.
    /// </summary>
    /// <remarks>
    /// Specifies the language code to be used by the underlying server when returning values as text for operations.
    /// Valid range: 0-65535.
    /// </remarks>
    int LanguageId { get; set; }

    /// <summary>
    /// Gets or sets the hold time in milliseconds.
    /// </summary>
    /// <remarks>
    /// Specifies the amount of time the server waits before continuing to wait or returning updates.
    /// Only applies in Exception Mode.
    /// Valid range: 0-36000000 ms.
    /// </remarks>
    int HoldTime { get; set; }

    /// <summary>
    /// Gets or sets the wait time in milliseconds.
    /// </summary>
    /// <remarks>
    /// Specifies the amount of time the server waits before returning updates from a SubscriptionPolledRefresh request if no data change occurs.
    /// Otherwise, the server returns a value any time during the Wait Time period on a data change.
    /// Only applies in Exception Mode.
    /// Valid range: 0-36000000 ms.
    /// </remarks>
    int WaitTime { get; set; }

    /// <summary>
    /// Gets or sets the percent deadband.
    /// </summary>
    /// <remarks>
    /// Specifies the minimum percent change needed in a tag's value for the remote server to return the value to the client
    /// based on a range of values that are determined by the server.
    /// Only applies in Exception Mode.
    /// Valid range: 0-100.
    /// </remarks>
    float PercentDeadband { get; set; }

    /// <summary>
    /// Gets or sets the maximum items per read request.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-512.
    /// </remarks>
    int MaxItemsPerRead { get; set; }

    /// <summary>
    /// Gets or sets the maximum items per write request.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-512.
    /// </remarks>
    int MaxItemsPerWrite { get; set; }

    /// <summary>
    /// Gets or sets the read timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Specifies the time allowed for asynchronous reads.
    /// Valid range: 100-2100000 ms.
    /// </remarks>
    int ReadTimeout { get; set; }

    /// <summary>
    /// Gets or sets the write timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Specifies the time allowed for asynchronous writes.
    /// Valid range: 100-2100000 ms.
    /// </remarks>
    int WriteTimeout { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to perform a read after writes.
    /// </summary>
    bool ReadAfterWrite { get; set; }
}