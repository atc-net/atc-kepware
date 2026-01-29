namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MtConnectClient;

/// <summary>
/// Device request properties for the MTConnect Client driver.
/// </summary>
public sealed class MtConnectClientDeviceRequest : DeviceRequestBase, IMtConnectClientDeviceRequest
{
    public MtConnectClientDeviceRequest()
        : base(DriverType.MtConnectClient)
    {
    }

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 80;

    /// <inheritdoc />
    public bool CloseAgentConnectionAfterEachRequest { get; set; } = true;

    /// <inheritdoc />
    public bool SchemaTagValidation { get; set; } = true;

    /// <inheritdoc />
    public bool ReadAllItemsInSingleRequest { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 100)]
    public int ItemsPerRequest { get; set; } = 25;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PortNumber)}: {PortNumber}, {nameof(CloseAgentConnectionAfterEachRequest)}: {CloseAgentConnectionAfterEachRequest}, {nameof(SchemaTagValidation)}: {SchemaTagValidation}, {nameof(ReadAllItemsInSingleRequest)}: {ReadAllItemsInSingleRequest}, {nameof(ItemsPerRequest)}: {ItemsPerRequest}";
}
