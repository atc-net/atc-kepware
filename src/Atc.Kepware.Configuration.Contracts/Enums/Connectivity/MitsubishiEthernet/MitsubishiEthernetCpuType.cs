namespace Atc.Kepware.Configuration.Contracts.Enums.Connectivity.MitsubishiEthernet;

/// <summary>
/// Specifies the target CPU type for Mitsubishi Ethernet devices.
/// </summary>
/// <remarks>
/// Only applicable for Q, QnA, L, iQ-F, and iQ-R series.
/// </remarks>
[SuppressMessage("Design", "CA1008:Enums should have zero value", Justification = "Values match Kepware API")]
public enum MitsubishiEthernetCpuType
{
    /// <summary>
    /// Control CPU.
    /// </summary>
    ControlCpu = 976,

    /// <summary>
    /// Standby CPU.
    /// </summary>
    StandbyCpu = 977,

    /// <summary>
    /// System A CPU.
    /// </summary>
    SystemACpu = 978,

    /// <summary>
    /// System B CPU.
    /// </summary>
    SystemBCpu = 979,

    /// <summary>
    /// CPU No.1.
    /// </summary>
    CpuNo1 = 992,

    /// <summary>
    /// CPU No.2.
    /// </summary>
    CpuNo2 = 993,

    /// <summary>
    /// CPU No.3.
    /// </summary>
    CpuNo3 = 994,

    /// <summary>
    /// CPU No.4.
    /// </summary>
    CpuNo4 = 995,

    /// <summary>
    /// Local CPU (default for single CPU).
    /// </summary>
    LocalCpu = 1023,
}