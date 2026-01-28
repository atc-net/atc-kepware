namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC device request.
/// </summary>
public class AutomationDirectEbcDeviceRequest : DeviceRequestBase, IAutomationDirectEbcDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutomationDirectEbcDeviceRequest"/> class.
    /// </summary>
    public AutomationDirectEbcDeviceRequest()
        : base(DriverType.AutomationDirectEbc)
    {
    }

    /// <inheritdoc />
    public AutomationDirectEbcDeviceModel Model { get; set; } = AutomationDirectEbcDeviceModel.H2;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    public bool UseLinkWatchdog { get; set; }

    /// <inheritdoc />
    [Range(60, 32767)]
    public int WatchdogTimeoutMs { get; set; } = 60;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 28784;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int AutoTagGenerationPort { get; set; } = 28784;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
