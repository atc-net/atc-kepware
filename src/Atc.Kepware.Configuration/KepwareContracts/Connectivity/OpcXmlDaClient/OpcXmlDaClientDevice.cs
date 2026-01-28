namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.OpcXmlDaClient;

/// <summary>
/// Device properties for the OPC XML-DA Client driver.
/// </summary>
internal sealed class OpcXmlDaClientDevice : DeviceBase, IOpcXmlDaClientDevice
{
    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_RETURN_ITEM_TIME")]
    public bool ReturnItemTime { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_RETURN_ITEM_PATH")]
    public bool ReturnItemPath { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_RETURN_ITEM_NAME")]
    public bool ReturnItemName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_RETURN_DIAGNOSTIC_INFO")]
    public bool ReturnDiagnosticInfo { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_RETURN_ERROR_TEXT")]
    public bool ReturnErrorText { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_MAX_ITEMS_PER_READ")]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_MAX_ITEMS_PER_WRITE")]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    [JsonPropertyName("opcxmldaclient.DEVICE_READ_AFTER_WRITE")]
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}";
}
