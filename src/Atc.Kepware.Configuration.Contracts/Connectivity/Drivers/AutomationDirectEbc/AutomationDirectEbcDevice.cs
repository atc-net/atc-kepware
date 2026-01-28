namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC device.
/// </summary>
public class AutomationDirectEbcDevice : DeviceBase, IAutomationDirectEbcDevice
{
    /// <inheritdoc />
    public AutomationDirectEbcDeviceModel Model { get; set; } = AutomationDirectEbcDeviceModel.H2;

    /// <inheritdoc />
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public bool UseLinkWatchdog { get; set; }

    /// <inheritdoc />
    public int WatchdogTimeoutMs { get; set; } = 60;

    /// <inheritdoc />
    public int Port { get; set; } = 28784;

    /// <inheritdoc />
    public int AutoTagGenerationPort { get; set; } = 28784;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
