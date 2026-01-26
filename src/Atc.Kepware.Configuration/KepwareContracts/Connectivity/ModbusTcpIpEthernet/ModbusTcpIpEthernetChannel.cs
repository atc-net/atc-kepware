namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.ModbusTcpIpEthernet;

/// <summary>
/// Channel properties for the Modbus TCP/IP Ethernet driver.
/// </summary>
internal class ModbusTcpIpEthernetChannel : ChannelBase, IModbusTcpIpEthernetChannel
{
    [JsonPropertyName("servermain.CHANNEL_ETHERNET_COMMUNICATIONS_NETWORK_ADAPTER_STRING")]
    public string? NetworkAdapter { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_VIRTUAL_NETWORK")]
    public int? VirtualNetwork { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_TRANSACTIONS_PER_CYCLE")]
    public int TransactionsPerCycle { get; set; }

    [JsonPropertyName("servermain.CHANNEL_COMMUNICATIONS_SERIALIZATION_NETWORK_MODE")]
    public ModbusChannelNetworkModeType NetworkMode { get; set; }

    [JsonPropertyName("modbus_ethernet.CHANNEL_USE_ONE_OR_MORE_SOCKETS_PER_DEVICE")]
    public ModbusChannelSocketUtilizationType SocketUtilization { get; set; }

    [JsonPropertyName("modbus_ethernet.CHANNEL_MAXIMUM_SOCKETS_PER_DEVICE")]
    public int MaxSocketsPerDevice { get; set; }

    [JsonPropertyName("modbus_ethernet.CHANNEL_ETHERNET_PORT_NUMBER")]
    public int Port { get; set; }

    [JsonPropertyName("modbus_ethernet.CHANNEL_ETHERNET_PROTOCOL")]
    public ModbusChannelIpProtocolType IpProtocol { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}, {nameof(VirtualNetwork)}: {VirtualNetwork}, {nameof(TransactionsPerCycle)}: {TransactionsPerCycle}, {nameof(NetworkMode)}: {NetworkMode}, {nameof(SocketUtilization)}: {SocketUtilization}, {nameof(MaxSocketsPerDevice)}: {MaxSocketsPerDevice}, {nameof(Port)}: {Port}, {nameof(IpProtocol)}: {IpProtocol}";
}
