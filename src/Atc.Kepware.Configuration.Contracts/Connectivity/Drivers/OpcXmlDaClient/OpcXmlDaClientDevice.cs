namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcXmlDaClient;

/// <summary>
/// Represents an OPC XML-DA Client device.
/// </summary>
public class OpcXmlDaClientDevice : DeviceBase, IOpcXmlDaClientDevice
{
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
    public int MaxItemsPerRead { get; set; } = 512;

    /// <inheritdoc />
    public int MaxItemsPerWrite { get; set; } = 512;

    /// <inheritdoc />
    public bool ReadAfterWrite { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(MaxItemsPerRead)}: {MaxItemsPerRead}, {nameof(MaxItemsPerWrite)}: {MaxItemsPerWrite}";
}
