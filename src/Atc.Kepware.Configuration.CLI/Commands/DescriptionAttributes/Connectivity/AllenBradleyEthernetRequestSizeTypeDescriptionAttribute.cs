namespace Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.Connectivity;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class AllenBradleyEthernetRequestSizeTypeDescriptionAttribute : DescriptionAttribute
{
    public override string Description
    {
        get
        {
            const AllenBradleyEthernetRequestSizeType defaultValue = AllenBradleyEthernetRequestSizeType.Bytes512;
            var values = Enum.GetNames(typeof(AllenBradleyEthernetRequestSizeType))
                .Select(enumValue => enumValue.Equals(defaultValue.ToString(), StringComparison.Ordinal)
                    ? $"{enumValue} (default)"
                    : enumValue)
                .ToList();

            return "Sets the request size in bytes. Valid values are: " +
                   string.Join(", ", values);
        }
    }
}
