namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC channel request.
/// </summary>
public class AutomationDirectEbcChannelRequest : ChannelRequestBase, IAutomationDirectEbcChannelRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutomationDirectEbcChannelRequest"/> class.
    /// </summary>
    public AutomationDirectEbcChannelRequest()
        : base(DriverType.AutomationDirectEbc)
    {
    }

    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}