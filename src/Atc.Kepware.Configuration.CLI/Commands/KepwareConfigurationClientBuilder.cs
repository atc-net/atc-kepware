namespace Atc.Kepware.Configuration.CLI.Commands;

public static class KepwareConfigurationClientBuilder
{
    public static KepwareConfigurationClient BuildKepwareConfigurationClient(
        KepwareBaseCommandSettings settings,
        ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(settings);

        var userName = settings.UserName;
        var password = settings.Password;

        return userName is not null && userName.IsSet
            ? new KepwareConfigurationClient(
                logger,
                new Uri(settings.ServerUrl),
                userName.Value,
                password!.Value)
            : new KepwareConfigurationClient(
                logger,
                new Uri(settings.ServerUrl),
                userName: null,
                password: null);
    }
}