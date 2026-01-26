namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.ModbusTcpIpEthernet;

public interface IModbusTcpIpEthernetChannel : IChannelBase
{
    /// <summary>
    /// Specify the name of a network adapter to bind or allow the OS to select the default.
    /// </summary>
    string? NetworkAdapter { get; set; }

    /// <summary>
    /// Limit data transmissions to one channel at a time by assigning this channel to a virtual network.
    /// 0 = None, 1-500 = Network 1-500.
    /// </summary>
    int? VirtualNetwork { get; set; }

    /// <summary>
    /// Specify the number of transactions to perform when a channel is given permission to communicate.
    /// </summary>
    int TransactionsPerCycle { get; set; }

    /// <summary>
    /// Choose whether to Load Balance for channels to communicate in a fixed order
    /// or Priority for order based on the type of operations pending.
    /// </summary>
    ModbusChannelNetworkModeType NetworkMode { get; set; }

    /// <summary>
    /// Specify how sockets are utilized for device communication.
    /// </summary>
    ModbusChannelSocketUtilizationType SocketUtilization { get; set; }

    /// <summary>
    /// Indicate the maximum number of sockets any device can use.
    /// </summary>
    int MaxSocketsPerDevice { get; set; }

    /// <summary>
    /// Specify the port number the driver can use to listen for unsolicited requests.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Indicate the Ethernet protocol for the driver to use when listening for unsolicited requests.
    /// </summary>
    ModbusChannelIpProtocolType IpProtocol { get; set; }
}
