namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.Connectivity;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ControlLogixDeviceModelTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const ControlLogixDeviceModelType defaultValue = ControlLogixDeviceModelType.ControlLogix5500;
            var values = Enum.GetNames(typeof(ControlLogixDeviceModelType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the device model. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}