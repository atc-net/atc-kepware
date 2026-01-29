namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.FanucFocasHssb;

/// <summary>
/// Device properties for the Fanuc Focas HSSB driver.
/// </summary>
public interface IFanucFocasHssbDevice : IDeviceBase
{
    /// <summary>
    /// The specific type of device.
    /// </summary>
    FanucFocasHssbDeviceModel Model { get; set; }

    /// <summary>
    /// Device identifier within the channel.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// The format of the device identifier.
    /// </summary>
    FanucFocasHssbDeviceIdFormat IdFormat { get; set; }

    /// <summary>
    /// The maximum number of bytes to request per read transaction.
    /// </summary>
    FanucFocasHssbMaximumRequestSize MaximumRequestSize { get; set; }
}
