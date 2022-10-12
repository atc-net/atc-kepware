namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.IotGateway;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class IotAgentPublishMessageFormatTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const IotAgentPublishMessageFormatType defaultValue = IotAgentPublishMessageFormatType.Advanced;
            var values = Enum.GetNames(typeof(IotAgentPublishMessageFormatType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Specifies how messages should be formatted. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}