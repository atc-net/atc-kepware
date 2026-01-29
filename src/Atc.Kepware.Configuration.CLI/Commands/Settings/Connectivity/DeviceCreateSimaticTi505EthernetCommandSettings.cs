namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateSimaticTi505EthernetCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--ip-protocol")]
    [Description("IP protocol (UDP or TCP)")]
    [DefaultValue(SimaticTi505EthernetIpProtocol.Udp)]
    public SimaticTi505EthernetIpProtocol IpProtocol { get; init; } = SimaticTi505EthernetIpProtocol.Udp;

    [CommandOption("--port-number")]
    [Description("Port number that the remote device is configured to use")]
    [DefaultValue(1505)]
    public int PortNumber { get; init; } = 1505;

    [CommandOption("--request-size")]
    [Description("Number of bytes that may be requested from a device at one time (32, 64, 128, or 250 bytes)")]
    [DefaultValue(SimaticTi505EthernetRequestSize.Bytes250)]
    public SimaticTi505EthernetRequestSize RequestSize { get; init; } = SimaticTi505EthernetRequestSize.Bytes250;

    [CommandOption("--protocol")]
    [Description("505 protocol (CAMP or CAMP Plus Packed Task Code)")]
    [DefaultValue(SimaticTi505EthernetProtocol.CampPlusPackedTaskCode)]
    public SimaticTi505EthernetProtocol Protocol { get; init; } = SimaticTi505EthernetProtocol.CampPlusPackedTaskCode;
}
