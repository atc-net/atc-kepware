namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensS7PlusEthernet;

/// <summary>
/// Represents a Siemens S7 Plus Ethernet device.
/// </summary>
public class SiemensS7PlusEthernetDevice : DeviceBase, ISiemensS7PlusEthernetDevice
{
    /// <inheritdoc />
    public int Port { get; set; } = 102;

    /// <inheritdoc />
    public string? PlcPassword { get; set; }

    /// <inheritdoc />
    public bool IncludeIdbsFbs { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Port)}: {Port}";
}
