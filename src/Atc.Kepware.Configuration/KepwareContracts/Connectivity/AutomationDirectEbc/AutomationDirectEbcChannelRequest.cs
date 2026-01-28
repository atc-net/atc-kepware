namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.AutomationDirectEbc;

/// <summary>
/// AutomationDirect EBC channel request - Kepware format.
/// </summary>
internal sealed class AutomationDirectEbcChannelRequest : ChannelRequestBase, IAutomationDirectEbcChannelRequest
{
    public AutomationDirectEbcChannelRequest()
        : base(DriverType.AutomationDirectEbc)
    {
    }
}
