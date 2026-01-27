namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class ChannelCreateSiemensTcpIpServerEthernetCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--port-number")]
    [Description("Port number on which the driver will listen (0-65535)")]
    [DefaultValue(102)]
    public int PortNumber { get; init; } = 102;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (PortNumber < 0 || PortNumber > 65535)
        {
            return ValidationResult.Error("--port-number must be between 0 and 65535.");
        }

        return ValidationResult.Success();
    }
}
