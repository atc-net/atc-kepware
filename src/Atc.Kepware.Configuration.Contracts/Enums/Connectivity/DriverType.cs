// ReSharper disable CheckNamespace
namespace Atc.Kepware.Configuration.Contracts;

public enum DriverType
{
    None,

    [Description("EUROMAP 63")]
    EuroMap63,

    [Description("OPC UA Client")]
    OpcUaClient,

    [Description("Simulator")]
    Simulator,

    [Description("Modbus TCP/IP Ethernet")]
    ModbusTcpIpEthernet,

    [Description("Allen-Bradley ControlLogix Ethernet")]
    AllenBradleyControlLogixEthernet,

    [Description("Allen-Bradley Ethernet")]
    AllenBradleyEthernet,

    [Description("Siemens TCP/IP Ethernet")]
    SiemensTcpIpEthernet,

    [Description("Siemens S7 Plus Ethernet")]
    SiemensS7PlusEthernet,

    [Description("OPC DA Client")]
    OpcDaClient,

    [Description("Omron FINS Ethernet")]
    OmronFinsEthernet,

    [Description("Mitsubishi Ethernet")]
    MitsubishiEthernet,

    [Description("BACnet/IP")]
    BacNetIp,

    [Description("MQTT Client")]
    MqttClient,
}