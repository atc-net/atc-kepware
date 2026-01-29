namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.SystemMonitor;

/// <summary>
/// Channel properties for the System Monitor driver.
/// </summary>
/// <remarks>
/// The System Monitor driver has no additional channel properties beyond the base properties.
/// </remarks>
internal sealed class SystemMonitorChannelRequest : ChannelRequestBase, ISystemMonitorChannelRequest
{
    public SystemMonitorChannelRequest()
        : base(DriverType.SystemMonitor)
    {
    }
}
