namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.GeEthernet;

/// <summary>
/// GE Ethernet device.
/// </summary>
public class GeEthernetDevice : DeviceBase, IGeEthernetDevice
{
    /// <inheritdoc />
    public GeEthernetModel Model { get; set; } = GeEthernetModel.PacSystems;

    /// <inheritdoc />
    public int PortNumber { get; set; }

    /// <inheritdoc />
    public GeEthernetMaxBytesPerRequest MaxBytesPerRequest { get; set; }

    /// <inheritdoc />
    public string VariableImportFile { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool DisplayDescriptions { get; set; }

    /// <inheritdoc />
    public bool UseAliasDataTypeIfPossible { get; set; }

    /// <inheritdoc />
    public string ProgramName { get; set; } = string.Empty;

    /// <inheritdoc />
    public int CpuSlotLocation { get; set; }
}