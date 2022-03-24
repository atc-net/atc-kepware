namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ChannelOptimizationMethodTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const ChannelOptimizationMethodType defaultValue = ChannelOptimizationMethodType.WriteOnlyLatestValueForAllTags;
            var values = Enum.GetNames(typeof(ChannelOptimizationMethodType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the OptimizationMethod. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}