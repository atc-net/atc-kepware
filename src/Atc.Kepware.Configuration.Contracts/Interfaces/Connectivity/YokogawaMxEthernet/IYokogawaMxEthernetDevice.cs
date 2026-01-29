namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YokogawaMxEthernet;

/// <summary>
/// Interface for Yokogawa MX Ethernet device.
/// </summary>
public interface IYokogawaMxEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    YokogawaMxEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to stop MX when the server is exited.
    /// </summary>
    bool StopMxOnShutdown { get; set; }

    /// <summary>
    /// Gets or sets the data handling for special condition statuses.
    /// </summary>
    YokogawaMxEthernetDataHandling DataHandling { get; set; }

    /// <summary>
    /// Gets or sets the source of the date and time data.
    /// </summary>
    YokogawaMxEthernetDateTimeSource DateAndTime { get; set; }

    /// <summary>
    /// Gets or sets the date format for the return string.
    /// </summary>
    YokogawaMxEthernetDateFormat DateFormat { get; set; }
}
