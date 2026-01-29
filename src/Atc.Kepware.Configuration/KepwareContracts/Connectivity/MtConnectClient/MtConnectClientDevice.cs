namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.MtConnectClient;

/// <summary>
/// Device properties for the MTConnect Client driver.
/// </summary>
internal class MtConnectClientDevice : DeviceBase, IMtConnectClientDevice
{
    /// <summary>
    /// Specify the port number.
    /// </summary>
    [JsonPropertyName("mtconnect_client.DEVICE_PORT_NUMBER")]
    public int PortNumber { get; set; }

    /// <summary>
    /// Specify Enable to close the socket connection with the agent after each read request.
    /// </summary>
    [JsonPropertyName("mtconnect_client.DEVICE_CLOSE_AFTER_REQUEST")]
    public bool CloseAgentConnectionAfterEachRequest { get; set; }

    /// <summary>
    /// Specify Enable to validate tags via schema.
    /// </summary>
    [JsonPropertyName("mtconnect_client.DEVICE_SCHEMA_TAG_VALIDATION")]
    public bool SchemaTagValidation { get; set; }

    /// <summary>
    /// Specify Yes to read all Items with one request, No to set the number of items read per request.
    /// </summary>
    [JsonPropertyName("mtconnect_client.READ_ALL_ITEMS_SINGLE_REQUEST")]
    public bool ReadAllItemsInSingleRequest { get; set; }

    /// <summary>
    /// Specify how many data items are bundled together in each read request.
    /// </summary>
    [JsonPropertyName("mtconnect_client.DEVICE_ITEMS_PER_REQUEST")]
    public int ItemsPerRequest { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(PortNumber)}: {PortNumber}, {nameof(CloseAgentConnectionAfterEachRequest)}: {CloseAgentConnectionAfterEachRequest}, {nameof(SchemaTagValidation)}: {SchemaTagValidation}, {nameof(ReadAllItemsInSingleRequest)}: {ReadAllItemsInSingleRequest}, {nameof(ItemsPerRequest)}: {ItemsPerRequest}";
}
