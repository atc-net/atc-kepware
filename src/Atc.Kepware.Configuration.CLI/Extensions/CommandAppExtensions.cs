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

            node
                .AddCommand<ChannelsGetCommand>("get")
                .WithDescription("Get channels");

            ConfigureChannelCreateCommands(node);

            node
                .AddCommand<ChannelDeleteCommand>("delete")
                .WithDescription("Delete channel");
        };

    private static void ConfigureChannelCreateCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating channels.");
            create.AddCommand<ChannelCreateEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 channel (if not exists).")
                .WithExample(new[] { "channels create euromap63" }); // TODO: Fix

            create.AddCommand<ChannelCreateOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client channel (if not exists).")
                .WithExample(new[] { "channels create opcuaclient" }); // TODO: Fix
        });

    private static Action<IConfigurator<CommandSettings>> ConfigureDevicesCommands()
        => node =>
        {
            node.SetDescription("Commands for devices");

            node
                .AddCommand<DevicesGetCommand>("get")
                .WithDescription("Get devices for channel");

            ConfigureDeviceCreateCommands(node);

            node
                .AddCommand<DeviceDeleteCommand>("delete")
                .WithDescription("Delete device from channel");
        };

    private static void ConfigureDeviceCreateCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating devices.");
            create.AddCommand<DeviceCreateEuroMap63Command>("euromap63")
                .WithDescription("Creates a EuroMap63 device (if not exists).")
                .WithExample(new[] { "devices create euromap63" }); // TODO: Fix

            create.AddCommand<DeviceCreateOpcUaClientCommand>("opcuaclient")
                .WithDescription("Creates a OPC UA Client device (if not exists).")
                .WithExample(new[] { "devices create opcuaclient" }); // TODO: Fix
        });

    private static Action<IConfigurator<CommandSettings>> ConfigureTagsCommands()
        => node =>
        {
            node.SetDescription("Commands for tags");

            node
                .AddCommand<TagsGetCommand>("get")
                .WithDescription("Get tags for channel and device");

            node
                .AddCommand<TagsSearchCommand>("search")
                .WithDescription("Search tags")
                .WithExample(new[] { "tags search -s [server] --search MyTag" })
                .WithExample(new[] { "tags search -s [server] --search *Tag" })
                .WithExample(new[] { "tags search -s [server] --search My*" })
                .WithExample(new[] { "tags search -s [server] --search *yt*" });

            ConfigureTagCreateCommands(node);
            ConfigureTagDeleteCommands(node);
        };

    private static void ConfigureTagCreateCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("create", create =>
        {
            create.SetDescription("Operations related to creating tags and tag groups.");
            create.AddCommand<TagsCreateTagCommand>("tag")
                .WithDescription("Creates a tag (if not exists).")
                .WithExample(new[] { "tags create tag" }); // TODO: Fix

            create.AddCommand<TagsCreateTagGroupCommand>("taggroup")
                .WithDescription("Creates a tag group (if not exists).")
                .WithExample(new[] { "tags create taggroup" }); // TODO: Fix
        });

    private static void ConfigureTagDeleteCommands(IConfigurator<CommandSettings> node)
        => node.AddBranch("delete", create =>
        {
            create.SetDescription("Operations related to deleting tags and tag groups.");
            create.AddCommand<TagsDeleteTagCommand>("tag")
                .WithDescription("Delete a tag (if exists).")
                .WithExample(new[] { "tags delete tag" }); // TODO: Fix

            create.AddCommand<TagsDeleteTagGroupCommand>("taggroup")
                .WithDescription("Deletes a tag group (if exists).")
                .WithExample(new[] { "tags delete taggroup" }); // TODO: Fix
        });
}