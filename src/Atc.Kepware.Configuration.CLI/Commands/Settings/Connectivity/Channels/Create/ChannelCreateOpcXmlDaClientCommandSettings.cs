namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Channels.Create;

public class ChannelCreateOpcXmlDaClientCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--opc-xml-da-server-url <OPC-XML-DA-SERVER-URL>")]
    [Description("URL of the OPC XML-DA server to connect to")]
    public string OpcXmlDaServerUrl { get; init; } = "http://localhost:80/Kepware/xmldaservice.asp";

    [CommandOption("--keep-alive")]
    [Description("Keep-alive interval in seconds (0-3600)")]
    [DefaultValue(0)]
    public int KeepAlive { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(OpcXmlDaServerUrl))
        {
            return ValidationResult.Error("--opc-xml-da-server-url is required.");
        }

        if (KeepAlive < 0 || KeepAlive > 3600)
        {
            return ValidationResult.Error("--keep-alive must be between 0 and 3600.");
        }

        return ValidationResult.Success();
    }
}