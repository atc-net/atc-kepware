namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.Connectivity;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class TagDataTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const TagDataType defaultValue = TagDataType.String;
            var values = Enum.GetNames(typeof(TagDataType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the Tag DataType. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}