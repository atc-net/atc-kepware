namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ChannelNonNormalizedFloatingPointHandlingTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const ChannelNonNormalizedFloatingPointHandlingType defaultValue = ChannelNonNormalizedFloatingPointHandlingType.ReplaceWithZero;
            var values = Enum.GetNames(typeof(ChannelNonNormalizedFloatingPointHandlingType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the NonNormalizedFloatingPointHandling. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}