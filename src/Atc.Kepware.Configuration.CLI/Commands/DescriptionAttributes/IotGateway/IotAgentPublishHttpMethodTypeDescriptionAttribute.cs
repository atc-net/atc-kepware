namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.IotGateway;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class IotAgentPublishHttpMethodTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const IotAgentPublishHttpMethodType defaultValue = IotAgentPublishHttpMethodType.Post;
            var values = Enum.GetNames(typeof(IotAgentPublishHttpMethodType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the HttpMethod for Publishing. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}