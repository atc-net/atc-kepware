namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.SiemensS7PlusEthernet;

/// <summary>
/// Represents a Siemens S7 Plus Ethernet channel.
/// </summary>
public class SiemensS7PlusEthernetChannel : ChannelBase, ISiemensS7PlusEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}