namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensS7PlusEthernet;

/// <summary>
/// Represents a Siemens S7 Plus Ethernet channel creation request.
/// </summary>
public class SiemensS7PlusEthernetChannelRequest : ChannelRequestBase, ISiemensS7PlusEthernetChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SiemensS7PlusEthernetChannelRequest"/> class.
    /// </summary>
    public SiemensS7PlusEthernetChannelRequest()
        : base(DriverType.SiemensS7PlusEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}