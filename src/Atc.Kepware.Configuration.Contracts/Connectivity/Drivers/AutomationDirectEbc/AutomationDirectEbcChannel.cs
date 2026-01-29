namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC channel.
/// </summary>
public class AutomationDirectEbcChannel : ChannelBase, IAutomationDirectEbcChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}