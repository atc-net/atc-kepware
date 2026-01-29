namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ModbusTcpIpEthernet;

/// <summary>
/// Channel request properties for the Modbus TCP/IP Ethernet driver.
/// </summary>
internal class ModbusTcpIpEthernetChannelRequest : ChannelRequestBase, IModbusTcpIpEthernetChannelRequest
{
    public ModbusTcpIpEthernetChannelRequest()
        : base(DriverType.ModbusTcpIpEthernet)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    [Range(0, 500)]
    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_VIRTUAL_NETWORK")]
    public int? VirtualNetwork { get; set; }

    /// <inheritdoc />
    [Range(1, 99)]
    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_TRANSACTIONS_PER_CYCLE")]
    public int TransactionsPerCycle { get; set; } = 1;

    /// <inheritdoc />
    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_NETWORK_MODE")]
    public ModbusChannelNetworkModeType NetworkMode { get; set; } = ModbusChannelNetworkModeType.LoadBalanced;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.CHANNEL_USE_ONE_OR_MORE_SOCKETS_PER_DEVICE")]
    public ModbusChannelSocketUtilizationType SocketUtilization { get; set; } = ModbusChannelSocketUtilizationType.OneOrMoreSocketsPerDevice;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("modbus_ethernet.CHANNEL_MAXIMUM_SOCKETS_PER_DEVICE")]
    public int MaxSocketsPerDevice { get; set; } = 1;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonPropertyName("modbus_ethernet.CHANNEL_ETHERNET_PORT_NUMBER")]
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    [JsonPropertyName("modbus_ethernet.CHANNEL_ETHERNET_PROTOCOL")]
    public ModbusChannelIpProtocolType IpProtocol { get; set; } = ModbusChannelIpProtocolType.TcpIp;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(VirtualNetwork)}: {VirtualNetwork}, {nameof(TransactionsPerCycle)}: {TransactionsPerCycle}, {nameof(NetworkMode)}: {NetworkMode}, {nameof(SocketUtilization)}: {SocketUtilization}, {nameof(MaxSocketsPerDevice)}: {MaxSocketsPerDevice}, {nameof(Port)}: {Port}, {nameof(IpProtocol)}: {IpProtocol}";
}