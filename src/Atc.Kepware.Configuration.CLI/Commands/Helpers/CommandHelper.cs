namespace Atc.Kepware.Configuration.CLI.Commands.Helpers;

public static class CommandHelper
{
    public static string GetIotItemInternalNameFromServerTag(
        string serverTag)
        => serverTag.TrimExtended().Replace('.', '_');
}