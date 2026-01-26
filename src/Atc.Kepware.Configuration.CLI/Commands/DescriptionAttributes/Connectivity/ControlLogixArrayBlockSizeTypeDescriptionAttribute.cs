namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.Connectivity;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ControlLogixArrayBlockSizeTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const ControlLogixArrayBlockSizeType defaultValue = ControlLogixArrayBlockSizeType.Elements120;
            var values = Enum.GetNames(typeof(ControlLogixArrayBlockSizeType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the array block size. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}
