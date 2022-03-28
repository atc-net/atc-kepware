namespace Atc.Kepware.Configuration.KepwareContracts;

internal sealed class TagRequest
{
    /// <summary>
    /// The name of the tag.
    /// </summary>
    [JsonPropertyName("common.ALLTYPES_NAME")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Description of the tag.
    /// </summary>
    [MaxLength(255)]
    [JsonPropertyName("common.ALLTYPES_DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The tag address.
    /// </summary>
    [JsonPropertyName("servermain.TAG_ADDRESS")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// The format of the incoming tag data.
    /// </summary>
    [JsonPropertyName("servermain.TAG_DATA_TYPE")]
    public TagDataType DataType { get; set; }

    /// <summary>
    /// Indicates the rights the client has in accessing the data.
    /// </summary>
    [JsonPropertyName("servermain.TAG_READ_WRITE_ACCESS")]
    public TagClientAccessType ClientAccess { get; set; }

    /// <summary>
    /// Specifies the poll interval, in milliseconds, for this tag.
    /// </summary>
    [JsonPropertyName("servermain.TAG_SCAN_RATE_MILLISECONDS")]
    public int ScanRate { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Address)}: {Address}, {nameof(DataType)}: {DataType}, {nameof(ClientAccess)}: {ClientAccess}, {nameof(ScanRate)}: {ScanRate}";
}