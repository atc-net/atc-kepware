namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyMicro800Ethernet;

public interface IAllenBradleyMicro800EthernetChannel : IChannelBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }
}
