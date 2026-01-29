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
    public OpcXmlDaClientUpdateMode UpdateMode { get; set; }

    /// <inheritdoc />
    [Range(100, 3600000)]
    public int UpdatePollRate { get; set; } = 5000;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int LanguageId { get; set; } = 1033;

    /// <inheritdoc />
    [Range(0, 36000000)]
    public int HoldTime { get; set; }

    /// <inheritdoc />
    [Range(0, 36000000)]
    public int WaitTime { get; set; }

    /// <inheritdoc />
    [Range(0, 100)]
    public float PercentDeadband { get; set; }

    /// <inheritdoc />
    [Range(1, 512)]
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    [Range(1, 512)]
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    [Range(100, 2100000)]
    public int ReadTimeout { get; set; } = 5000;

    /// <inheritdoc />
    [Range(100, 2100000)]
    public int WriteTimeout { get; set; } = 5000;

    /// <inheritdoc />
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}";
}
