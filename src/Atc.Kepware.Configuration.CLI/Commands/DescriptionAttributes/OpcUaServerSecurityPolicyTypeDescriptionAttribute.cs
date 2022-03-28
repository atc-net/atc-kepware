namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class OpcUaServerSecurityPolicyTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const OpcUaServerSecurityPolicyType defaultValue = OpcUaServerSecurityPolicyType.None;
            var values = Enum.GetNames(typeof(OpcUaServerSecurityPolicyType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the ServerSecurityPolicy. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}