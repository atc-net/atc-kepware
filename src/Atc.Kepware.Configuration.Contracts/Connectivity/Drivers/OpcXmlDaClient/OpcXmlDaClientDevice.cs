namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcXmlDaClient;

/// <summary>
/// Represents an OPC XML-DA Client device.
/// </summary>
public class OpcXmlDaClientDevice : DeviceBase, IOpcXmlDaClientDevice
{
    /// <inheritdoc />
    public OpcXmlDaClientUpdateMode UpdateMode { get; set; }

    /// <inheritdoc />
    public int UpdatePollRate { get; set; } = 5000;

    /// <inheritdoc />
    public int LanguageId { get; set; } = 1033;

    /// <inheritdoc />
    public int HoldTime { get; set; }

    /// <inheritdoc />
    public int WaitTime { get; set; }

    /// <inheritdoc />
    public float PercentDeadband { get; set; }

    /// <inheritdoc />
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    public int ReadTimeout { get; set; } = 5000;

    /// <inheritdoc />
    public int WriteTimeout { get; set; } = 5000;

    /// <inheritdoc />
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(UpdateMode)}: {UpdateMode}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}";
}