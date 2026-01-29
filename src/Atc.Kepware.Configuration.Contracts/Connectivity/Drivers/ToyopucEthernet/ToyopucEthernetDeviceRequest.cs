namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ToyopucEthernet;

/// <summary>
/// Represents a Toyopuc Ethernet device creation request.
/// </summary>
public class ToyopucEthernetDeviceRequest : DeviceRequestBase, IToyopucEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ToyopucEthernetDeviceRequest"/> class.
    /// </summary>
    public ToyopucEthernetDeviceRequest()
        : base(DriverType.ToyopucEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "127.0.0.1";

    /// <inheritdoc />
    public ToyopucEthernetDeviceModelType Model { get; set; } = ToyopucEthernetDeviceModelType.Pc2_Pc2Interchange;

    /// <inheritdoc />
    [Range(1025, 65534)]
    public int DevicePort { get; set; } = 4096;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Model)}: {Model}";
}