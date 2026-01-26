namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ModbusTcpIpEthernet;

public sealed class ModbusTcpIpEthernetChannel : ChannelBase, IModbusTcpIpEthernetChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public int? VirtualNetwork { get; set; }

    /// <inheritdoc />
    public int TransactionsPerCycle { get; set; }

    /// <inheritdoc />
    public ModbusChannelNetworkModeType NetworkMode { get; set; }

    /// <inheritdoc />
    public ModbusChannelSocketUtilizationType SocketUtilization { get; set; }

    /// <inheritdoc />
    public int MaxSocketsPerDevice { get; set; }

    /// <inheritdoc />
    public int Port { get; set; }

    /// <inheritdoc />
    public ModbusChannelIpProtocolType IpProtocol { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(VirtualNetwork)}: {VirtualNetwork}, {nameof(TransactionsPerCycle)}: {TransactionsPerCycle}, {nameof(NetworkMode)}: {NetworkMode}, {nameof(SocketUtilization)}: {SocketUtilization}, {nameof(MaxSocketsPerDevice)}: {MaxSocketsPerDevice}, {nameof(Port)}: {Port}, {nameof(IpProtocol)}: {IpProtocol}";
}
