namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.GeEthernet;

/// <summary>
/// GE Ethernet device request.
/// </summary>
public class GeEthernetDeviceRequest : DeviceRequestBase, IGeEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeEthernetDeviceRequest"/> class.
    /// </summary>
    public GeEthernetDeviceRequest()
        : base(DriverType.GeEthernet)
    {
    }

    /// <inheritdoc />
    public GeEthernetModel Model { get; set; } = GeEthernetModel.PacSystems;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PortNumber { get; set; } = 18245;

    /// <inheritdoc />
    public GeEthernetMaxBytesPerRequest MaxBytesPerRequest { get; set; } = GeEthernetMaxBytesPerRequest.Bytes2048;

    /// <inheritdoc />
    [MaxLength(256)]
    public string VariableImportFile { get; set; } = "*.snf";

    /// <inheritdoc />
    public bool DisplayDescriptions { get; set; } = true;

    /// <inheritdoc />
    public bool UseAliasDataTypeIfPossible { get; set; }

    /// <inheritdoc />
    [MaxLength(7)]
    public string ProgramName { get; set; } = "PROGRAM";

    /// <inheritdoc />
    [Range(0, 15)]
    public int CpuSlotLocation { get; set; } = 1;
}
