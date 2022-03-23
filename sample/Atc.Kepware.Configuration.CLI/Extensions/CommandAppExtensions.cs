namespace Atc.Kepware.Configuration.CLI.Extensions;

public static class CommandAppExtensions
{
    public static void ConfigureCommands(this CommandApp<RootCommand> app)
    {
        ArgumentNullException.ThrowIfNull(app);

        app.Configure(config =>
        {
            config.AddBranch("channels", ConfigureChannelsCommands());
        });
    }

    private static Action<IConfigurator<CommandSettings>> ConfigureChannelsCommands()
        => node =>
        {
            node.SetDescription("Commands for channels");

            node
                .AddCommand<ChannelsGetCommand>("get")
                .WithDescription("Get channels");
        };
}