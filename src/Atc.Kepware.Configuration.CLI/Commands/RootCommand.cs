namespace Atc.Kepware.Configuration.CLI.Commands;

public class RootCommand : AsyncCommand<RootCommandSettings>
{
    public override Task<int> ExecuteAsync(
        CommandContext context,
        RootCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    private static async Task<int> ExecuteInternalAsync(
        RootCommandSettings settings)
    {
        if (!NetworkInformationHelper.HasConnection())
        {
            System.Console.WriteLine("This tool requires internet connection!");
            return ConsoleExitStatusCodes.Failure;
        }

        if (settings.IsOptionValueTrue(settings.Version))
        {
            try
            {
                HandleVersionOption();
            }
            catch
            {
                return ConsoleExitStatusCodes.Failure;
            }
        }

        await Task.Delay(1);
        return ConsoleExitStatusCodes.Success;
    }

    private static void HandleVersionOption()
        => System.Console.WriteLine(CliHelper.GetCurrentVersion().ToString());
}