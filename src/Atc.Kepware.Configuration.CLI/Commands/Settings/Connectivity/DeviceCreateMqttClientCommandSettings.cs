namespace Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;

public class DeviceCreateMqttClientCommandSettings : DeviceCreateCommandBaseSettings
{
    [CommandOption("--tag-generation-topic [TAG-GENERATION-TOPIC]")]
    [Description("Topic for automatic tag generation")]
    public FlagValue<string>? TagGenerationTopic { get; init; } = new();

    [CommandOption("--tag-generation-duration")]
    [Description("Duration for automatic tag generation in seconds (10-3600)")]
    [DefaultValue(60)]
    public int TagGenerationDuration { get; init; }

    [CommandOption("--cancel-tag-generation")]
    [Description("Cancel automatic tag generation in progress")]
    [DefaultValue(false)]
    public bool CancelTagGeneration { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (TagGenerationDuration < 10 || TagGenerationDuration > 3600)
        {
            return ValidationResult.Error("--tag-generation-duration must be between 10 and 3600.");
        }

        return ValidationResult.Success();
    }
}