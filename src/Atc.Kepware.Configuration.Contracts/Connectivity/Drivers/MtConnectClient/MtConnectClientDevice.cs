namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MtConnectClient;

/// <summary>
/// Device properties for the MTConnect Client driver.
/// </summary>
public sealed class MtConnectClientDevice : DeviceBase, IMtConnectClientDevice
{
    /// <inheritdoc />
    public int PortNumber { get; set; }

    /// <inheritdoc />
    public bool CloseAgentConnectionAfterEachRequest { get; set; }

    /// <inheritdoc />
    public bool SchemaTagValidation { get; set; }

    /// <inheritdoc />
    public bool ReadAllItemsInSingleRequest { get; set; }

    /// <inheritdoc />
    public int ItemsPerRequest { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(PortNumber)}: {PortNumber}, {nameof(CloseAgentConnectionAfterEachRequest)}: {CloseAgentConnectionAfterEachRequest}, {nameof(SchemaTagValidation)}: {SchemaTagValidation}, {nameof(ReadAllItemsInSingleRequest)}: {ReadAllItemsInSingleRequest}, {nameof(ItemsPerRequest)}: {ItemsPerRequest}";
}
