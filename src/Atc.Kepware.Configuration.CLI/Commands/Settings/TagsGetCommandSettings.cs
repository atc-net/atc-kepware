namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class TagsGetCommandSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("--maxdepth <MAXDEPTH>")]
    [Description("Max depth for tag retrieval")]
    public int MaxDepth { get; set; } = 1000;
}