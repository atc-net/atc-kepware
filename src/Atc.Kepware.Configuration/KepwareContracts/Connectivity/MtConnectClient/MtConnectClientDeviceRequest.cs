namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MtConnectClient;

/// <summary>
/// Device request properties for the MTConnect Client driver.
/// </summary>
internal class MtConnectClientDeviceRequest : DeviceRequestBase, IMtConnectClientDeviceRequest
{
    public MtConnectClientDeviceRequest()
        : base(DriverType.MtConnectClient)
    {
    }

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("mtconnect_client.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; } = 80;

    /// <inheritdoc />
    [JsonPropertyName("mtconnect_client.DEVICE_CLOSE_AFTER_REQUEST")]
    public bool CloseAgentConnectionAfterEachRequest { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("mtconnect_client.DEVICE_SCHEMA_TAG_VALIDATION")]
    public bool SchemaTagValidation { get; set; } = true;

    /// <inheritdoc />
    [JsonPropertyName("mtconnect_client.READ_ALL_ITEMS_SINGLE_REQUEST")]
    public bool ReadAllItemsInSingleRequest { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 100)]
    [JsonPropertyName("mtconnect_client.DEVICE_ITEMS_PER_REQUEST")]
    public int ItemsPerRequest { get; set; } = 25;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PortNumber)}: {PortNumber}, {nameof(CloseAgentConnectionAfterEachRequest)}: {CloseAgentConnectionAfterEachRequest}, {nameof(SchemaTagValidation)}: {SchemaTagValidation}, {nameof(ReadAllItemsInSingleRequest)}: {ReadAllItemsInSingleRequest}, {nameof(ItemsPerRequest)}: {ItemsPerRequest}";
}
