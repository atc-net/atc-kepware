namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.Connectivity;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class AllenBradleyEthernetDeviceModelTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const AllenBradleyEthernetDeviceModelType defaultValue = AllenBradleyEthernetDeviceModelType.Slc505Open;
            var values = Enum.GetNames(typeof(AllenBradleyEthernetDeviceModelType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the device model. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}
