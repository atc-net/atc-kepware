namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FanucFocasHssb;

/// <summary>
/// Device request properties for the Fanuc Focas HSSB driver.
/// </summary>
public sealed class FanucFocasHssbDeviceRequest : DeviceRequestBase, IFanucFocasHssbDeviceRequest
{
    public FanucFocasHssbDeviceRequest()
        : base(DriverType.FanucFocasHssb)
    {
    }

    /// <inheritdoc />
    public FanucFocasHssbDeviceModel Model { get; set; } = FanucFocasHssbDeviceModel.Series15i;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Id { get; set; }

    /// <inheritdoc />
    public FanucFocasHssbDeviceIdFormat IdFormat { get; set; } = FanucFocasHssbDeviceIdFormat.Decimal;

    /// <inheritdoc />
    public FanucFocasHssbMaximumRequestSize MaximumRequestSize { get; set; } = FanucFocasHssbMaximumRequestSize.Bytes256;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}, {nameof(MaximumRequestSize)}: {MaximumRequestSize}";
}
