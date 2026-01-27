namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YokogawaGxEthernet;

/// <summary>
/// Interface for Yokogawa GX Ethernet device request.
/// </summary>
public interface IYokogawaGxEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    YokogawaGxEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the data handling for out of range and error conditions.
    /// </summary>
    YokogawaGxEthernetDataHandling DataHandling { get; set; }

    /// <summary>
    /// Gets or sets the polling interval in milliseconds.
    /// </summary>
    int PollingInterval { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to start math computation on communication startup.
    /// </summary>
    bool StartMath { get; set; }

    /// <summary>
    /// Gets or sets the source of the date and time data.
    /// </summary>
    YokogawaGxEthernetDateTimeSource DateAndTime { get; set; }

    /// <summary>
    /// Gets or sets the date format for the return string.
    /// </summary>
    YokogawaGxEthernetDateFormat DateFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to set the device clock on communication startup.
    /// </summary>
    bool SetClock { get; set; }

    /// <summary>
    /// Gets or sets the tag database generation source.
    /// </summary>
    YokogawaGxEthernetTagDatabaseSource TagDatabaseSource { get; set; }
}
