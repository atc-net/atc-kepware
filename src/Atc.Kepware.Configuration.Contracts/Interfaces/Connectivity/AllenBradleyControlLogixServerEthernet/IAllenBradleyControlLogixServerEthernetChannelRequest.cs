namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyControlLogixServerEthernet;

public interface IAllenBradleyControlLogixServerEthernetChannelRequest : IChannelRequestBase
{
    /// <summary>
    /// Specify the TCP/IP and UDP port to provide a unique communication channel to the EtherNet/IP module.
    /// </summary>
    /// <remarks>
    /// Range: 1-65535, Default: 44818.
    /// </remarks>
    int Port { get; set; }
}