namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ModbusTcpIpEthernet;

/// <summary>
/// Channel properties for the Modbus TCP/IP Ethernet driver.
/// </summary>
public sealed class ModbusTcpIpEthernetChannelRequest : ChannelRequestBase, IModbusTcpIpEthernetChannelRequest
{
    public ModbusTcpIpEthernetChannelRequest()
        : base(DriverType.ModbusTcpIpEthernet)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [Range(0, 500)]
    public int? VirtualNetwork { get; set; }

    /// <inheritdoc />
    [Range(1, 99)]
    public int TransactionsPerCycle { get; set; } = 1;

    /// <inheritdoc />
    public ModbusChannelNetworkModeType NetworkMode { get; set; } = ModbusChannelNetworkModeType.LoadBalanced;

    /// <inheritdoc />
    public ModbusChannelSocketUtilizationType SocketUtilization { get; set; } = ModbusChannelSocketUtilizationType.OneOrMoreSocketsPerDevice;

    /// <inheritdoc />
    [Range(1, 10)]
    public int MaxSocketsPerDevice { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    public ModbusChannelIpProtocolType IpProtocol { get; set; } = ModbusChannelIpProtocolType.TcpIp;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(VirtualNetwork)}: {VirtualNetwork}, {nameof(TransactionsPerCycle)}: {TransactionsPerCycle}, {nameof(NetworkMode)}: {NetworkMode}, {nameof(SocketUtilization)}: {SocketUtilization}, {nameof(MaxSocketsPerDevice)}: {MaxSocketsPerDevice}, {nameof(Port)}: {Port}, {nameof(IpProtocol)}: {IpProtocol}";
}
