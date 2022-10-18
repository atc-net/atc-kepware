namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public class IotItemGetCommandSettings : IotItemCommandBaseSettings
{
    [CommandOption("--server-tag <SERVER-TAG>")]
    [Description("The server tag of the Iot Item")]
    public string ServerTag { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        var isValidName = IsValidName(IotAgentName);
        if (!isValidName.Successful)
        {
            return isValidName;
        }

        return ValidationResult.Success();
    }
}