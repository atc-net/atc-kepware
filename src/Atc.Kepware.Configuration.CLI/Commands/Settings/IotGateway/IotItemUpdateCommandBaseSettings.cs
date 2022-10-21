namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public class IotItemUpdateCommandBaseSettings : KepwareBaseCommandSettings
{
    [CommandOption("--iot-agent-name <IOT-AGENT-NAME>")]
    [Description("Iot Agent Name (Not updateable, but required for updating the Iot Agent Iot Item!)")]
    public string IotAgentName { get; init; } = string.Empty;

    [CommandOption("--server-tag <SERVER-TAG>")]
    [Description("The server tag the Iot Item is pointing to (Not updateable, but required for updating the Iot Agent Iot Item!)")]
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