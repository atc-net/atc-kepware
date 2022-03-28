namespace Atc.Kepware.Configuration.Contracts;

public sealed class TagRequest
{
    /// <summary>
    /// The name of the tag.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Description of the tag.
    /// </summary>
    [MaxLength(255)]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The tag address.
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// The format of the incoming tag data.
    /// </summary>
    public TagDataType DataType { get; set; }

    /// <summary>
    /// Indicates the rights the client has in accessing the data.
    /// </summary>
    public TagClientAccessType ClientAccess { get; set; }

    /// <summary>
    /// Specifies the poll interval, in milliseconds, for this tag.
    /// </summary>
    public int ScanRate { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Address)}: {Address}, {nameof(DataType)}: {DataType}, {nameof(ClientAccess)}: {ClientAccess}, {nameof(ScanRate)}: {ScanRate}";
}