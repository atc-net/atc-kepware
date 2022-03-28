namespace Atc.Kepware.Configuration.CLI.Extensions;

public static class CommandAppExtensions
{
    public static void ConfigureCommands(this CommandApp<RootCommand> app)
    {
        ArgumentNullException.ThrowIfNull(app);

        app.Configure(config =>
        {
            config.AddBranch("channels", ConfigureChannelsCommands());
            config.AddBranch("devices", ConfigureDevicesCommands());
            config.AddBranch("tags", ConfigureTagsCommands());
        });
    }

    private static Action<IConfigurator<CommandSettings>> ConfigureChannelsCommands()
        => node =>
        {
            node.SetDescription("Commands for channels");

            ConfigureChannelGetCommands(node);

            ConfigureChannelCreateCommands(node);

            node
                .AddCommand<ChannelDeleteCommand>("delete")
                .WithDescription("Delete channel");
        };

    private static void ConfigureChannelGetCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("get", get =>
        {
            get.SetDescription("Operations related to retrieving channels.");

            get.AddCommand<ChannelsGetCommand>("all")
                .WithDescription("Retrieve all channels")
                .WithExample(new[] { "channels get all" });

            get.AddCommand<ChannelGetEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 channel (if not exists).")
                .WithExample(new[] { "channels get euromap63 --name [channelName]" });

            get.AddCommand<ChannelGetOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client channel (if not exists).")
                .WithExample(new[] { "channels get opcuaclient --name [channelName]" });
        });

    private static void ConfigureChannelCreateCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating channels.");
            create.AddCommand<ChannelCreateEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 channel (if not exists).")
                .WithExample(new[] { "channels create euromap63 --name [channelName] --description [description]" });

            create.AddCommand<ChannelCreateOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client channel (if not exists).")
                .WithExample(new[] { "channels create opcuaclient --name [channelName] --description [description]" });
        });

    private static Action<IConfigurator<CommandSettings>> ConfigureDevicesCommands()
        => node =>
        {
            node.SetDescription("Commands for devices");

            ConfigureDeviceGetCommands(node);

            ConfigureDeviceCreateCommands(node);

            node
                .AddCommand<DeviceDeleteCommand>("delete")
                .WithDescription("Delete device from channel");
        };

    private static void ConfigureDeviceGetCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("get", get =>
        {
            get.SetDescription("Operations related to retrieving devices.");

            get
                .AddCommand<DevicesGetByChannelCommand>("all")
                .WithDescription("Retrieve all devices by channel-name")
                .WithExample(new[] { "devices get all --channel-name [channelName]" });

            get.AddCommand<DeviceGetEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 device (if not exists).")
                .WithExample(new[] { "devices get euromap63 --channel-name [channelName] --device-name [deviceName]" });

            get.AddCommand<DeviceGetOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client device (if not exists).")
                .WithExample(new[] { "devices get opcuaclient --channel-name [channelName] --device-name [deviceName]" });
        });

    private static void ConfigureDeviceCreateCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating devices.");

            create.AddCommand<DeviceCreateEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 device (if not exists).")
                .WithExample(new[] { "devices create euromap63 --channel-name [channelName] --device-name [deviceName] --description [description] --session-file-path [filePath]" });

            create.AddCommand<DeviceCreateOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client device (if not exists).")
                .WithExample(new[] { "devices create opcuaclient --channel-name [channelName] --device-name [deviceName] --description [description] " });
        });

    private static Action<IConfigurator<CommandSettings>> ConfigureTagsCommands()
        => node =>
        {
            node.SetDescription("Commands for tags");

            node
                .AddCommand<TagsGetCommand>("get")
                .WithDescription("Get tags for channel and device");

            ConfigureTagCreateCommands(node);
            ConfigureTagDeleteCommands(node);

            node
                .AddCommand<TagsSearchCommand>("search")
                .WithDescription("Search tags")
                .WithExample(new[] { "tags search -s [server] --search MyTag" })
                .WithExample(new[] { "tags search -s [server] --search *Tag" })
                .WithExample(new[] { "tags search -s [server] --search My*" })
                .WithExample(new[] { "tags search -s [server] --search *yt*" });
        };

    private static void ConfigureTagCreateCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating tags and tag groups.");

            create.AddCommand<TagsCreateTagCommand>("tag")
                .WithDescription("Creates a tag (if not exists).")
                .WithExample(new[] { "tags create tag --channel-name [channelName] --device-name [deviceName] --name [tagName] --address [tagAddress] --scan-rate [scanRate] --data-type [dataType] --client-access [clientAccess] --description [description]" });

            create.AddCommand<TagsCreateTagGroupCommand>("taggroup")
                .WithDescription("Creates a tag group (if not exists).")
                .WithExample(new[] { "tags create taggroup --channel-name [channelName] --device-name [deviceName] --name [tagGroupName] --description [description]" });
        });

    private static void ConfigureTagDeleteCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("delete", create =>
        {
            create.SetDescription("Operations related to deleting tags and tag groups.");

            create.AddCommand<TagsDeleteTagCommand>("tag")
                .WithDescription("Delete a tag (if exists).")
                .WithExample(new[] { "tags delete tag --name [tagName]" });

            create.AddCommand<TagsDeleteTagGroupCommand>("taggroup")
                .WithDescription("Deletes a tag group (if exists).")
                .WithExample(new[] { "tags delete taggroup --name [tagGroupName]" });
        });
}