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

////    ScalingType* ScalingType    `json:"servermain.TAG_SCALING_TYPE,omitempty"`                0
////    RawLow* int            `json:"servermain.TAG_SCALING_RAW_LOW,omitempty"`                  0
////    RawHigh* int            `json:"servermain.TAG_SCALING_RAW_HIGH,omitempty"`                1000
////    ScaledDataType* ScaledDataType `json:"servermain.TAG_SCALING_SCALED_DATA_TYPE,omitempty"` 9
////    ScaledLow* int            `json:"servermain.TAG_SCALING_SCALED_LOW,omitempty"`            0
////    ScaledHigh* int            `json:"servermain.TAG_SCALING_SCALED_HIGH,omitempty"`          1000
////    ClampLow* bool           `json:"servermain.TAG_SCALING_CLAMP_LOW,omitempty"`              false
////    ClampHigh* bool           `json:"servermain.TAG_SCALING_CLAMP_HIGH,omitempty"`            false
////    NegateValue* bool           `json:"servermain.TAG_SCALING_NEGATE_VALUE,omitempty"`        false
////    Units* string         `json:"servermain.TAG_SCALING_UNITS,omitempty"`                     ""