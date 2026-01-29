namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FanucFocasHssb;

/// <summary>
/// Device request properties for the Fanuc Focas HSSB driver.
/// </summary>
internal sealed class FanucFocasHssbDeviceRequest : DeviceRequestBase, IFanucFocasHssbDeviceRequest
{
    public FanucFocasHssbDeviceRequest()
        : base(DriverType.FanucFocasHssb)
    {
    }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public FanucFocasHssbDeviceModel Model { get; set; } = FanucFocasHssbDeviceModel.Series15i;

    /// <inheritdoc />
    [Range(0, 65535)]
    [JsonIgnore]
    public int Id { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public FanucFocasHssbDeviceIdFormat IdFormat { get; set; } = FanucFocasHssbDeviceIdFormat.Decimal;

    [JsonPropertyName("servermain.DEVICE_ID_OCTAL")]
    public int OctalId => Id;

    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int DecimalId => Id;

    [JsonPropertyName("servermain.DEVICE_ID_HEXADECIMAL")]
    public int HexadecimalId => Id;

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_hssb.DEVICE_MAXIMUM_REQUEST_SIZE")]
    public FanucFocasHssbMaximumRequestSize MaximumRequestSize { get; set; } = FanucFocasHssbMaximumRequestSize.Bytes256;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}, {nameof(MaximumRequestSize)}: {MaximumRequestSize}";
}