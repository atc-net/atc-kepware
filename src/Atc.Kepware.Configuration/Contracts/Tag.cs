namespace Atc.Kepware.Configuration.Contracts;

public class Tag
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public TagDataType DataType { get; set; }

    public TagClientAccessType ClientAccess { get; set; }

    public int ScanRate { get; set; }
}