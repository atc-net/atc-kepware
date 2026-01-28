namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcXmlDaClient;

/// <summary>
/// Represents an OPC XML-DA Client device creation request.
/// </summary>
public class OpcXmlDaClientDeviceRequest : DeviceRequestBase, IOpcXmlDaClientDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpcXmlDaClientDeviceRequest"/> class.
    /// </summary>
    public OpcXmlDaClientDeviceRequest()
        : base(DriverType.OpcXmlDaClient)
    {
    }

    /// <inheritdoc />
    public bool ReturnItemTime { get; set; } = true;

    /// <inheritdoc />
    public bool ReturnItemPath { get; set; }

    /// <inheritdoc />
    public bool ReturnItemName { get; set; }

    /// <inheritdoc />
    public bool ReturnDiagnosticInfo { get; set; }

    /// <inheritdoc />
    public bool ReturnErrorText { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 512)]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    [Range(1, 512)]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}";
}
