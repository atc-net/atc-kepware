namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity.Channels.Create;

public class ChannelCreateOpcDaClientCommandSettings : ChannelCreateCommandBaseSettings
{
    [CommandOption("--program-id <PROGRAM-ID>")]
    [Description("Program ID of the OPC server to connect to")]
    public string ProgramId { get; init; } = string.Empty;

    [CommandOption("--remote-machine-name [REMOTE-MACHINE-NAME]")]
    [Description("Name of the remote machine where the OPC server resides")]
    public FlagValue<string>? RemoteMachineName { get; init; } = new();

    [CommandOption("--connection-type [CONNECTION-TYPE]")]
    [Description("Connection type (InProc, Local, Any)")]
    public FlagValue<OpcDaClientConnectionType>? ConnectionType { get; init; } = new();

    [CommandOption("--failed-connection-retry-interval")]
    [Description("Time in seconds between connection attempts (5-600)")]
    [DefaultValue(5)]
    public int FailedConnectionRetryInterval { get; init; }

    [CommandOption("--server-status-query-interval")]
    [Description("How often in seconds the driver tests the connection (5-30)")]
    [DefaultValue(5)]
    public int ServerStatusQueryInterval { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(ProgramId))
        {
            return ValidationResult.Error("--program-id is required.");
        }

        if (FailedConnectionRetryInterval < 5 || FailedConnectionRetryInterval > 600)
        {
            return ValidationResult.Error("--failed-connection-retry-interval must be between 5 and 600.");
        }

        if (ServerStatusQueryInterval < 5 || ServerStatusQueryInterval > 30)
        {
            return ValidationResult.Error("--server-status-query-interval must be between 5 and 30.");
        }

        return ValidationResult.Success();
    }
}