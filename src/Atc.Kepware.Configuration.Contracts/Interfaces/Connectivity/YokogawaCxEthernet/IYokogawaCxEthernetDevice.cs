namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YokogawaCxEthernet;

/// <summary>
/// Interface for Yokogawa CX Ethernet device.
/// </summary>
public interface IYokogawaCxEthernetDevice : IDeviceBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    YokogawaCxEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the data handling for out of range and error conditions.
    /// </summary>
    YokogawaCxEthernetDataHandling DataHandling { get; set; }

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
    YokogawaCxEthernetDateTimeSource DateAndTime { get; set; }

    /// <summary>
    /// Gets or sets the date format for the return string.
    /// </summary>
    YokogawaCxEthernetDateFormat DateFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to set the device clock on communication startup.
    /// </summary>
    bool SetClock { get; set; }

    /// <summary>
    /// Gets or sets the tag database generation source.
    /// </summary>
    YokogawaCxEthernetTagDatabaseSource TagDatabaseSource { get; set; }

    /// <summary>
    /// Gets or sets the username for device login.
    /// </summary>
    string Username { get; set; }

    /// <summary>
    /// Gets or sets the password for device login.
    /// </summary>
    string Password { get; set; }
}
