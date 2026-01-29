namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YokogawaDarwinEthernet;

/// <summary>
/// Interface for Yokogawa Darwin Ethernet device.
/// </summary>
public interface IYokogawaDarwinEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    YokogawaDarwinEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the data handling for out of range and error conditions.
    /// </summary>
    YokogawaDarwinEthernetDataHandling DataHandling { get; set; }

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
    YokogawaDarwinEthernetDateTimeSource DateAndTime { get; set; }

    /// <summary>
    /// Gets or sets the date format for the return string.
    /// </summary>
    YokogawaDarwinEthernetDateFormat DateFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to set the device clock on communication startup.
    /// </summary>
    bool SetClock { get; set; }

    /// <summary>
    /// Gets or sets the tag database generation source.
    /// </summary>
    YokogawaDarwinEthernetTagDatabaseSource TagDatabaseSource { get; set; }
}