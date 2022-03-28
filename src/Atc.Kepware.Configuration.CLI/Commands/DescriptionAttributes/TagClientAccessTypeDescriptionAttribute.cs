namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class TagClientAccessTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const TagClientAccessType defaultValue = TagClientAccessType.ReadWrite;
            var values = Enum.GetNames(typeof(TagDataType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the Tag ClientAccessType. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}