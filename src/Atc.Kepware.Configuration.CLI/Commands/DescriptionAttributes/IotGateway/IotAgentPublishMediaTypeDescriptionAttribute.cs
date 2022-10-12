namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.IotGateway;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class IotAgentPublishMediaTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const IotAgentPublishMediaType defaultValue = IotAgentPublishMediaType.Json;
            var values = Enum.GetNames(typeof(IotAgentPublishMediaType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the media type for Publishing. Only valid when PublishMessageFormat is set to (Advanced). Valid values are: " +
                   string.Join(", ", values);
        }
    }
}