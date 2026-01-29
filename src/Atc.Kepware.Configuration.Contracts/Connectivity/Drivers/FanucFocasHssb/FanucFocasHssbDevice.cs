namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.FanucFocasHssb;

/// <summary>
/// Device properties for the Fanuc Focas HSSB driver.
/// </summary>
public sealed class FanucFocasHssbDevice : DeviceBase, IFanucFocasHssbDevice
{
    /// <inheritdoc />
    public FanucFocasHssbDeviceModel Model { get; set; }

    /// <inheritdoc />
    public int Id { get; set; }

    /// <inheritdoc />
    public FanucFocasHssbDeviceIdFormat IdFormat { get; set; } = FanucFocasHssbDeviceIdFormat.Decimal;

    /// <inheritdoc />
    public FanucFocasHssbMaximumRequestSize MaximumRequestSize { get; set; } = FanucFocasHssbMaximumRequestSize.Bytes256;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(Id)}: {Id}, {nameof(IdFormat)}: {IdFormat}, {nameof(MaximumRequestSize)}: {MaximumRequestSize}";
}
