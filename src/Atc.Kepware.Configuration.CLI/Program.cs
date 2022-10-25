namespace Atc.Kepware.Configuration.CLI;

public static class Program
{
    public static Task<int> Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        args = SetHelpArgumentIfNeeded(args);

        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        var consoleLoggerConfiguration = new ConsoleLoggerConfiguration();
        configuration.GetSection("ConsoleLogger").Bind(consoleLoggerConfiguration);

        ProgramCsHelper.SetMinimumLogLevelIfNeeded(args, consoleLoggerConfiguration);

        var serviceCollection = ServiceCollectionFactory.Create(consoleLoggerConfiguration);

        serviceCollection.AddTransient<IKepwareConfigurationClient, KepwareConfigurationClient>(s =>
        {
            var loggerFactory = s.GetRequiredService<ILoggerFactory>();
            return new KepwareConfigurationClient(loggerFactory.CreateLogger<KepwareConfigurationClient>());
        });

        var app = CommandAppFactory.CreateWithRootCommand<RootCommand>(serviceCollection);
        app.ConfigureCommands();

        return app.RunAsync(args);
    }

    private static string[] SetHelpArgumentIfNeeded(
        string[] args)
    {
        if (args.Length == 0)
        {
            return new[] { CommandConstants.ArgumentShortHelp };
        }

        // TODO: Add multiple command help commands
        return args;
    }
}