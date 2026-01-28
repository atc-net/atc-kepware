namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectEcom;

/// <summary>
/// Channel properties for the AutomationDirect ECOM driver.
/// </summary>
public sealed class AutomationDirectEcomChannelRequest : ChannelRequestBase, IAutomationDirectEcomChannelRequest
{
    public AutomationDirectEcomChannelRequest()
        : base(DriverType.AutomationDirectEcom)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}
