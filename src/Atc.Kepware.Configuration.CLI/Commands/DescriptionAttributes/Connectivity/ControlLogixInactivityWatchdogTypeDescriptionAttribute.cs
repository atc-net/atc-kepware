namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.Connectivity;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ControlLogixInactivityWatchdogTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const ControlLogixInactivityWatchdogType defaultValue = ControlLogixInactivityWatchdogType.Seconds32;
            var values = Enum.GetNames(typeof(ControlLogixInactivityWatchdogType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the inactivity watchdog timeout. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}