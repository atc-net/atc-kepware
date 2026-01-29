namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Tags;

public class TagsGetCommandSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("--max-depth <MAX-DEPTH>")]
    [Description("Max depth for tag retrieval")]
    public int MaxDepth { get; set; } = 1000;
}