namespace Atc.Kepware.Configuration.CLI.Commands.Helpers;

public static class CommandHelper
{
    public static string GetIotItemInternalNameFromServerTag(string serverTag)
        => serverTag.TrimExtended().Replace('.', '_');

    public static string TransformHttpHeaders(
        IDictionary<string, string> httpHeaders)
    {
        ArgumentNullException.ThrowIfNull(httpHeaders);

        var sb = new StringBuilder();

        foreach (var httpHeader in httpHeaders)
        {
            sb.Append($"{httpHeader.Key}: {httpHeader.Value}{Environment.NewLine}", GlobalizationConstants.EnglishCultureInfo);
        }

        return sb.ToString();
    }
}