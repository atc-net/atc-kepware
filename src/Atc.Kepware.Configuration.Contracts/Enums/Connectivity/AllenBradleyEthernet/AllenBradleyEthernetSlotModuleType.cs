// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.AllenBradleyEthernet;

/// <summary>
/// Allen-Bradley Ethernet SLC slot module types.
/// </summary>
[SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Names match Kepware module naming convention")]
public enum AllenBradleyEthernetSlotModuleType
{
    /// <summary>
    /// No Module.
    /// </summary>
    NoModule = 255,

    /// <summary>
    /// 1746-I*8 Any 8 pt Discrete Input Module.
    /// </summary>
    Input8pt = 0,

    /// <summary>
    /// 1746-I*16 Any 16 pt Discrete Input Module.
    /// </summary>
    Input16pt = 1,

    /// <summary>
    /// 1746-I*32 Any 32 pt Discrete Input Module.
    /// </summary>
    Input32pt = 2,

    /// <summary>
    /// 1746-O*8 Any 8 pt Discrete Output Module.
    /// </summary>
    Output8pt = 3,

    /// <summary>
    /// 1746-O*16 Any 16 pt Discrete Output Module.
    /// </summary>
    Output16pt = 4,

    /// <summary>
    /// 1746-O*32 Any 32 pt Discrete Output Module.
    /// </summary>
    Output32pt = 5,

    /// <summary>
    /// 1746-IA4 4 Input 100/120 VAC.
    /// </summary>
    IA4 = 6,

    /// <summary>
    /// 1746-IA8 8 Input 100/120 VAC.
    /// </summary>
    IA8 = 7,

    /// <summary>
    /// 1746-IA16 16 Input 100/120 VAC.
    /// </summary>
    IA16 = 8,

    /// <summary>
    /// 1746-IB8 8 Input (Sink) 24 VDC.
    /// </summary>
    IB8 = 9,

    /// <summary>
    /// 1746-IB16 16 Input (Sink) 24 VDC.
    /// </summary>
    IB16 = 10,

    /// <summary>
    /// 1746-IB32 32 Input (Sink) 24 VDC.
    /// </summary>
    IB32 = 11,

    /// <summary>
    /// 1746-IG16 16 Input [TTL] (Source) 5VDC.
    /// </summary>
    IG16 = 12,

    /// <summary>
    /// 1746-IM4 4 Input 200/240 VAC.
    /// </summary>
    IM4 = 13,

    /// <summary>
    /// 1746-IM8 8 Input 200/240 VAC.
    /// </summary>
    IM8 = 14,

    /// <summary>
    /// 1746-IM16 16 Input 200/240 VAC.
    /// </summary>
    IM16 = 15,

    /// <summary>
    /// 1746-IN16 16 Input 24 VAC/VDC.
    /// </summary>
    IN16 = 16,

    /// <summary>
    /// 1746-ITB16 16 Input [Fast] (Sink) 24 VDC.
    /// </summary>
    ITB16 = 17,

    /// <summary>
    /// 1746-ITV16 16 Input [Fast] (Source) 24 VDC.
    /// </summary>
    ITV16 = 18,

    /// <summary>
    /// 1746-IV8 8 Input (Source) 24 VDC.
    /// </summary>
    IV8 = 19,

    /// <summary>
    /// 1746-IV16 16 Input (Source) 24 VDC.
    /// </summary>
    IV16 = 20,

    /// <summary>
    /// 1746-IV32 32 Input (Source) 24 VDC.
    /// </summary>
    IV32 = 21,

    /// <summary>
    /// 1746-OA8 8 Output (Triac) 100/240 VAC.
    /// </summary>
    OA8 = 22,

    /// <summary>
    /// 1746-OA16 16 Output (Triac) 100/240 VAC.
    /// </summary>
    OA16 = 23,

    /// <summary>
    /// 1746-OB8 8 Output [Trans] (Source) 10/50 VDC.
    /// </summary>
    OB8 = 24,

    /// <summary>
    /// 1746-OB16 16 Output [Trans] (Source) 10/50 VDC.
    /// </summary>
    OB16 = 25,

    /// <summary>
    /// 1746-OB32 32 Output [Trans] (Source) 10/50 VDC.
    /// </summary>
    OB32 = 26,

    /// <summary>
    /// 1746-OBP16 16 Output [Trans 1 amp] (SRC) 24 VDC.
    /// </summary>
    OBP16 = 27,

    /// <summary>
    /// 1746-OV8 8 Output [Trans] (Sink) 10/50 VDC.
    /// </summary>
    OV8 = 28,

    /// <summary>
    /// 1746-OV16 16 Output [Trans] (Sink) 10/50 VDC.
    /// </summary>
    OV16 = 29,

    /// <summary>
    /// 1746-OV32 32 Output [Trans] (Sink) 10/50 VDC.
    /// </summary>
    OV32 = 30,

    /// <summary>
    /// 1746-OW4 4 Output [Relay] VAC/VDC.
    /// </summary>
    OW4 = 31,

    /// <summary>
    /// 1746-OW8 8 Output [Relay] VAC/VDC.
    /// </summary>
    OW8 = 32,

    /// <summary>
    /// 1746-OW16 16 Output [Relay] VAC/VDC.
    /// </summary>
    OW16 = 33,

    /// <summary>
    /// 1746-OX8 8 Output [Isolated Relay] VAC/VDC.
    /// </summary>
    OX8 = 34,

    /// <summary>
    /// 1746-OVP16 16 Output [Trans 1 amp] (Sink) 24VDC.
    /// </summary>
    OVP16 = 35,

    /// <summary>
    /// 1746-IO4 2 In 100/120 VAC 2 Out [Rly] VAC/VDC.
    /// </summary>
    IO4 = 36,

    /// <summary>
    /// 1746-IO8 4 In 100/120 VAC 4 Out [Rly] VAC/VDC.
    /// </summary>
    IO8 = 37,

    /// <summary>
    /// 1746-IO12 6 In 100/120 VAC 6 Out [Rly] VAC/VDC.
    /// </summary>
    IO12 = 38,

    /// <summary>
    /// 1746-NI4 4 Ch. Analog Input.
    /// </summary>
    NI4 = 39,

    /// <summary>
    /// 1746-NIO4I Analog Comb 2 in and 2 Current Out.
    /// </summary>
    NIO4I = 40,

    /// <summary>
    /// 1746-NIO4V Analog Comb 2 in and 2 Voltage Out.
    /// </summary>
    NIO4V = 41,

    /// <summary>
    /// 1746-NO4I 4 Ch. Analog Current Output.
    /// </summary>
    NO4I = 42,

    /// <summary>
    /// 1746-NO4V 4 Ch. Analog Voltage Output.
    /// </summary>
    NO4V = 43,

    /// <summary>
    /// 1746-NT4 4 Ch. Thermocouple Input Module.
    /// </summary>
    NT4 = 44,

    /// <summary>
    /// 1746-NR4 4 Ch. Rtd/Resistance Input Module.
    /// </summary>
    NR4 = 45,

    /// <summary>
    /// 1746-HSCE High Speed Counter/Encoder.
    /// </summary>
    HSCE = 46,

    /// <summary>
    /// 1746-HS Single Axis Motion Controller.
    /// </summary>
    HS = 47,

    /// <summary>
    /// 1746-OG16 16 Output [TLL] (SINK) 5 VDC.
    /// </summary>
    OG16 = 48,

    /// <summary>
    /// 1746-BAS Basic Module 500 5/01 Configuration.
    /// </summary>
    BAS_501 = 49,

    /// <summary>
    /// 1746-BAS Basic Module 5/02 Configuration.
    /// </summary>
    BAS_502 = 50,

    /// <summary>
    /// 1747-DCM Direct Communication Module (1/4 Rack).
    /// </summary>
    DCM_Quarter = 51,

    /// <summary>
    /// 1747-DCM Direct Communication Module (1/2 Rack).
    /// </summary>
    DCM_Half = 52,

    /// <summary>
    /// 1747-DCM Direct Communication Module (3/4 Rack).
    /// </summary>
    DCM_ThreeQuarter = 53,

    /// <summary>
    /// 1747-DCM Direct Communication Module (Full Rack).
    /// </summary>
    DCM_Full = 54,

    /// <summary>
    /// 1747-SN Remote I/O Scanner.
    /// </summary>
    SN = 55,

    /// <summary>
    /// 1747-DSN Distributed I/O Scanner 7 Blocks.
    /// </summary>
    DSN_7Blocks = 56,

    /// <summary>
    /// 1747-DSN Distributed I/O Scanner 30 Blocks.
    /// </summary>
    DSN_30Blocks = 57,

    /// <summary>
    /// 1747-KE Interface Module, Series A.
    /// </summary>
    KE_SeriesA = 58,

    /// <summary>
    /// 1747-KE Interface Module, Series B.
    /// </summary>
    KE_SeriesB = 59,

    /// <summary>
    /// 1746-NI8 8 Ch. Analog Input, Class 1.
    /// </summary>
    NI8_Class1 = 60,

    /// <summary>
    /// 1746-NI8 8 Ch. Analog Input, Class 3.
    /// </summary>
    NI8_Class3 = 61,

    /// <summary>
    /// 0000-Generic Module.
    /// </summary>
    GenericModule = 62,

    /// <summary>
    /// 1746-IC16 16 Input (Sink) 48 VDC.
    /// </summary>
    IC16 = 63,

    /// <summary>
    /// 1746-IH16 16 Input [Trans] (Sink) 125 VDC.
    /// </summary>
    IH16 = 64,

    /// <summary>
    /// 1746-OAP12 12 Output [Triac] 120/240 VDC.
    /// </summary>
    OAP12 = 65,

    /// <summary>
    /// 1746-OB6EI 6 Output [Trans] (Source) 24 VDC.
    /// </summary>
    OB6EI = 66,

    /// <summary>
    /// 1746-OB16E 16 Output [Trans] (Source) Protected.
    /// </summary>
    OB16E = 67,

    /// <summary>
    /// 1746-OB32E 32 Output [Trans] (Source) 10/50 VDC.
    /// </summary>
    OB32E = 68,

    /// <summary>
    /// 1746-OBP8 8 Output [Trans 2 amp] (Source) 24 VDC.
    /// </summary>
    OBP8 = 69,

    /// <summary>
    /// 1746-IO12DC 6 Input 12 VDC, 6 Output [Rly].
    /// </summary>
    IO12DC = 70,

    /// <summary>
    /// 1746-INI4I Analog 4 Ch. Isol. Current Input.
    /// </summary>
    INI4I = 71,

    /// <summary>
    /// 1746-INI4VI Analog 4 Ch. Isol. Volt./Current Input.
    /// </summary>
    INI4VI = 72,

    /// <summary>
    /// 1746-INO4I Analog 4 Ch. Isol. Current Output.
    /// </summary>
    INO4I = 73,

    /// <summary>
    /// 1746-INO4VI Analog 4 Ch. Isol. Volt./Current Output.
    /// </summary>
    INO4VI = 74,

    /// <summary>
    /// 1746-INT4 Analog 4 Ch. Isol. Thermocouple Input.
    /// </summary>
    INT4 = 75,

    /// <summary>
    /// 1746-NT8 Analog 8 Ch. Thermocouple Input.
    /// </summary>
    NT8 = 76,

    /// <summary>
    /// 1746-HSRV Motion Control Module.
    /// </summary>
    HSRV = 77,

    /// <summary>
    /// 1746-HSTP1 Stepper Controller Module.
    /// </summary>
    HSTP1 = 78,

    /// <summary>
    /// 1747-MNET MNET Network Comm. Module.
    /// </summary>
    MNET = 79,

    /// <summary>
    /// 1747-QS Synchronized Axes Module.
    /// </summary>
    QS = 80,

    /// <summary>
    /// 1747-QV Open Loop Velocity Control Module.
    /// </summary>
    QV = 81,

    /// <summary>
    /// 1747-RCIF Robot Control Interface Module.
    /// </summary>
    RCIF = 82,

    /// <summary>
    /// 1747-SCNR ControlNet SLC Scanner.
    /// </summary>
    SCNR = 83,

    /// <summary>
    /// 1747-SDN DeviceNet Scanner.
    /// </summary>
    SDN = 84,

    /// <summary>
    /// 1394-SJT GMC Turbo System.
    /// </summary>
    SJT = 85,

    /// <summary>
    /// 1203-SM1 SCANport Comm. Module - Basic.
    /// </summary>
    SM1_Basic = 86,

    /// <summary>
    /// 1203-SM1 SCANport Comm. Module - Enhanced.
    /// </summary>
    SM1_Enhanced = 87,

    /// <summary>
    /// AMCI-1561 AMCI Series 1561 Resolver Module.
    /// </summary>
    AMCI1561 = 88,
}