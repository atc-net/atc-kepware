namespace Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway.IotItem.Retrieve;

public class IotItemGetCommandSettings : IotItemCommandBaseSettings
{
    [CommandOption("--server-tag <SERVER-TAG>")]
    [Description("The server tag of the Iot Item")]
    public string ServerTag { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        return validationResult.Successful
            ? ValidationResult.Success()
            : validationResult;
    }
}