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

    [Description("Omron NJ Ethernet")]
    OmronNjEthernet,

    [Description("Mitsubishi Ethernet")]
    MitsubishiEthernet,

    [Description("BACnet/IP")]
    BacNetIp,

    [Description("MQTT Client")]
    MqttClient,

    [Description("DNP Client Ethernet")]
    DnpClientEthernet,

    [Description("Allen-Bradley ControlLogix Server Ethernet")]
    AllenBradleyControlLogixServerEthernet,

    [Description("Allen-Bradley Micro800 Ethernet")]
    AllenBradleyMicro800Ethernet,

    [Description("Allen-Bradley Server Ethernet")]
    AllenBradleyServerEthernet,

    [Description("Siemens TCP/IP Server Ethernet")]
    SiemensTcpIpServerEthernet,

    [Description("Mitsubishi CNC Ethernet")]
    MitsubishiCncEthernet,

    [Description("Mitsubishi FX Net")]
    MitsubishiFxNet,

    [Description("GE Ethernet")]
    GeEthernet,

    [Description("GE Ethernet Global Data")]
    GeEthernetGlobalData,

    [Description("Yokogawa CX Ethernet")]
    YokogawaCxEthernet,

    [Description("Yokogawa Darwin Ethernet")]
    YokogawaDarwinEthernet,

    [Description("Yokogawa DX Ethernet")]
    YokogawaDxEthernet,

    [Description("Yokogawa DXP Ethernet")]
    YokogawaDxpEthernet,

    [Description("Yokogawa GX Ethernet")]
    YokogawaGxEthernet,

    [Description("Yokogawa MW Ethernet")]
    YokogawaMwEthernet,

    [Description("Yokogawa MX Ethernet")]
    YokogawaMxEthernet,

    [Description("IEC 60870-5-104 Client")]
    Iec608705104Client,

    [Description("IEC 61850 MMS Client")]
    Iec61850MmsClient,

    [Description("Aromat Ethernet")]
    AromatEthernet,

    [Description("AutomationDirect Productivity Series Ethernet")]
    AutomationDirectProductivitySeriesEthernet,

    [Description("AutomationDirect EBC")]
    AutomationDirectEbc,

    [Description("AutomationDirect ECOM")]
    AutomationDirectEcom,

    [Description("Beckhoff TwinCAT")]
    BeckhoffTwinCat,

    [Description("Alstom Redundant Ethernet")]
    AlstomRedundantEthernet,

    [Description("Bristol BSAP IP")]
    BristolBsapIp,

    [Description("Busware Ethernet")]
    BuswareEthernet,

    [Description("Honeywell HC900 Ethernet")]
    HoneywellHc900Ethernet,

    [Description("Fanuc Focas Ethernet")]
    FanucFocasEthernet,

    [Description("Fanuc Focas HSSB")]
    FanucFocasHssb,

    [Description("Honeywell UDC Ethernet")]
    HoneywellUdcEthernet,

    [Description("CODESYS")]
    Codesys,

    [Description("Cutler-Hammer ELC Ethernet")]
    CutlerHammerElcEthernet,

    [Description("Keyence KV Ethernet")]
    KeyenceKvEthernet,

    [Description("OPC XML-DA Client")]
    OpcXmlDaClient,

    [Description("MTConnect Client")]
    MtConnectClient,

    [Description("Opto 22 Ethernet")]
    Opto22Ethernet,

    [Description("KraussMaffei MC4 Ethernet")]
    KraussMaffeiMc4Ethernet,

    [Description("SattBus Ethernet")]
    SattBusEthernet,

    [Description("Scanivalve Ethernet")]
    ScanivalveEthernet,

    [Description("SIXNET EtherTRAK")]
    SixnetEthertrak,

    [Description("Simatic/TI 505 Ethernet")]
    SimaticTi505Ethernet,

    [Description("SNMP")]
    Snmp,

    [Description("Thermo Westronics Ethernet")]
    ThermoWestronicsEthernet,

    [Description("Toshiba Ethernet")]
    ToshibaEthernet,

    [Description("Torque Tool Ethernet")]
    TorqueToolEthernet,

    [Description("Toyopuc PC3/PC2 Ethernet")]
    ToyopucEthernet,

    [Description("Triconex Ethernet")]
    TriconexEthernet,

    [Description("Wonderware InTouch Client")]
    WonderwareIntouchClient,

    [Description("Yaskawa MP Series Ethernet")]
    YaskawaMpSeriesEthernet,

    [Description("Wago Ethernet")]
    WagoEthernet,

    [Description("DDE Client")]
    DdeClient,

    [Description("Custom Interface")]
    CustomInterface,

    [Description("Allen-Bradley Bulletin 1609")]
    AllenBradleyBulletin1609,

    [Description("Allen-Bradley Bulletin 900")]
    AllenBradleyBulletin900,

    [Description("System Monitor")]
    SystemMonitor,

    [Description("Ping")]
    Ping,

    [Description("Memory Based")]
    MemoryBased,
}