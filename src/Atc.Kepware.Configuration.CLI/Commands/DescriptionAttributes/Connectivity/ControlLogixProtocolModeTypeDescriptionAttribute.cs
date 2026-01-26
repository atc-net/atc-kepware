namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.Connectivity;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ControlLogixProtocolModeTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const ControlLogixProtocolModeType defaultValue = ControlLogixProtocolModeType.LogicalNonBlocking;
            var values = Enum.GetNames(typeof(ControlLogixProtocolModeType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the protocol mode. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}
