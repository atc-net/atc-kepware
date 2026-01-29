namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AutomationDirectEcom;

public sealed class AutomationDirectEcomChannel : ChannelBase, IAutomationDirectEcomChannel
{
    /// <inheritdoc />
    public string? NetworkAdapter { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(NetworkAdapter)}: {NetworkAdapter}";
}