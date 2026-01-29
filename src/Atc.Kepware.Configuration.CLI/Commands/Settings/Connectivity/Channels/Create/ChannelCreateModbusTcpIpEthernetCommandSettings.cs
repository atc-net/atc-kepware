namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Channels.Create;

public class ChannelCreateModbusTcpIpEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--port")]
    [Description("Port number for Modbus TCP/IP Ethernet Channel")]
    [DefaultValue(502)]
    public int Port { get; init; }

    [CommandOption("--ip-protocol [IP-PROTOCOL]")]
    [Description("IP Protocol for Modbus TCP/IP Ethernet Channel (TcpIp, Udp)")]
    public FlagValue<ModbusChannelIpProtocolType>? IpProtocol { get; init; } = new();

    [CommandOption("--socket-utilization [SOCKET-UTILIZATION]")]
    [Description("Socket utilization mode (OneOrMoreSocketsPerDevice, SingleSocketPerChannel)")]
    public FlagValue<ModbusChannelSocketUtilizationType>? SocketUtilization { get; init; } = new();

    [CommandOption("--max-sockets-per-device")]
    [Description("Maximum number of sockets per device (1-10)")]
    [DefaultValue(1)]
    public int MaxSocketsPerDevice { get; init; }

    [CommandOption("--transactions-per-cycle")]
    [Description("Number of transactions per cycle (1-99)")]
    [DefaultValue(1)]
    public int TransactionsPerCycle { get; init; }

    [CommandOption("--network-mode [NETWORK-MODE]")]
    [Description("Network mode (LoadBalanced, Priority)")]
    public FlagValue<ModbusChannelNetworkModeType>? NetworkMode { get; init; } = new();

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (Port < 0 || Port > 65535)
        {
            return ValidationResult.Error("--port must be between 0 and 65535.");
        }

        if (MaxSocketsPerDevice < 1 || MaxSocketsPerDevice > 10)
        {
            return ValidationResult.Error("--max-sockets-per-device must be between 1 and 10.");
        }

        if (TransactionsPerCycle < 1 || TransactionsPerCycle > 99)
        {
            return ValidationResult.Error("--transactions-per-cycle must be between 1 and 99.");
        }

        return ValidationResult.Success();
    }
}