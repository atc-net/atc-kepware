namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;

public class IotItemCommandBaseSettings : KepwareBaseCommandSettings
{
    [CommandOption("--iot-agent-name <IOT-AGENT-NAME>")]
    [Description("Iot Agent Name")]
    public string IotAgentName { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        var isValidName = IsValidName(IotAgentName);
        return isValidName.Successful
            ? ValidationResult.Success()
            : isValidName;
    }
}