namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.IotGateway;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class IotAgentPublishFormatTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const IotAgentPublishFormatType defaultValue = IotAgentPublishFormatType.Narrow;
            var values = Enum.GetNames(typeof(IotAgentPublishFormatType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the format type for Publishing. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}