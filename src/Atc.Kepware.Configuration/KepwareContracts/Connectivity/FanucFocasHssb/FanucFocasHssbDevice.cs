namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.FanucFocasHssb;

/// <summary>
/// Device properties for the Fanuc Focas HSSB driver.
/// </summary>
internal sealed class FanucFocasHssbDevice : DeviceBase, IFanucFocasHssbDevice
{
    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_MODEL")]
    public FanucFocasHssbDeviceModel Model { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_DECIMAL")]
    public int Id { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("servermain.DEVICE_ID_FORMAT")]
    public FanucFocasHssbDeviceIdFormat IdFormat { get; set; } = FanucFocasHssbDeviceIdFormat.Decimal;

    /// <inheritdoc />
    [JsonPropertyName("ge_focas1_hssb.DEVICE_MAXIMUM_REQUEST_SIZE")]
    public FanucFocasHssbMaximumRequestSize MaximumRequestSize { get; set; } = FanucFocasHssbMaximumRequestSize.Bytes256;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}, {nameof(MaximumRequestSize)}: {MaximumRequestSize}";
}
