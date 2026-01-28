namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.OpcXmlDaClient;

/// <summary>
/// Defines the OPC XML-DA Client device request properties.
/// </summary>
public interface IOpcXmlDaClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets a value indicating whether to return item time.
    /// </summary>
    /// <remarks>
    /// When enabled, the server includes timestamps in responses.
    /// </remarks>
    bool ReturnItemTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to return item path.
    /// </summary>
    /// <remarks>
    /// When enabled, the server includes item paths in responses.
    /// </remarks>
    bool ReturnItemPath { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to return item name.
    /// </summary>
    /// <remarks>
    /// When enabled, the server includes item names in responses.
    /// </remarks>
    bool ReturnItemName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to return diagnostic info.
    /// </summary>
    /// <remarks>
    /// When enabled, the server includes diagnostic information in responses.
    /// </remarks>
    bool ReturnDiagnosticInfo { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to return error text.
    /// </summary>
    /// <remarks>
    /// When enabled, the server includes error text in responses.
    /// </remarks>
    bool ReturnErrorText { get; set; }

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
    /// Gets or sets a value indicating whether to perform a read after writes.
    /// </summary>
    bool ReadAfterWrite { get; set; }
}
