namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class TagsSearchCommandSettings : KepwareBaseCommandSettings
{
    [CommandOption("-c|--channel-name")]
    [Description("ChannelName")]
    public string ChannelName { get; init; } = string.Empty;

    [CommandOption("-d|--device-name")]
    [Description("DeviceName")]
    public string DeviceName { get; init; } = string.Empty;

    [CommandOption("-q|--query <QUERY>")]
    [Description("Query")]
    public string Query { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (!"*".Equals(ChannelName, StringComparison.Ordinal) ||
            !string.IsNullOrEmpty(ChannelName))
        {
            var isValidChannelName = IsValidName("channel-name", ChannelName);
            if (!isValidChannelName.Successful)
            {
                return isValidChannelName;
            }
        }

        if (!"*".Equals(ChannelName, StringComparison.Ordinal) ||
            !string.IsNullOrEmpty(DeviceName))
        {
            var isValidDeviceName = IsValidName("device-name", DeviceName);
            if (!isValidDeviceName.Successful)
            {
                return isValidDeviceName;
            }
        }

        if (string.IsNullOrEmpty(Query))
        {
            return ValidationResult.Error("--query is not set.");
        }

        return ValidationResult.Success();
    }
}