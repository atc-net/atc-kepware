namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class OpcUaServerMessageModeTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const OpcUaServerMessageModeType defaultValue = OpcUaServerMessageModeType.None;
            var values = Enum.GetNames(typeof(OpcUaServerMessageModeType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the ServerMessageMode. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}