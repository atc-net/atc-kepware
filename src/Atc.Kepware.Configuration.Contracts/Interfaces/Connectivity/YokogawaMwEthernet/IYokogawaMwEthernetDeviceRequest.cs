namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YokogawaMwEthernet;

/// <summary>
/// Interface for Yokogawa MW Ethernet device request.
/// </summary>
public interface IYokogawaMwEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    YokogawaMwEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the data handling for out of range and error conditions.
    /// </summary>
    YokogawaMwEthernetDataHandling DataHandling { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to start math computation on communication startup.
    /// </summary>
    bool StartMath { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to start measuring on communication startup.
    /// </summary>
    bool StartMeasuring { get; set; }

    /// <summary>
    /// Gets or sets the source of the date and time data.
    /// </summary>
    YokogawaMwEthernetDateTimeSource DateAndTime { get; set; }

    /// <summary>
    /// Gets or sets the date format for the return string.
    /// </summary>
    YokogawaMwEthernetDateFormat DateFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to set the device clock on communication startup.
    /// </summary>
    bool SetClock { get; set; }

    /// <summary>
    /// Gets or sets the tag database generation source.
    /// </summary>
    YokogawaMwEthernetTagDatabaseSource TagDatabaseSource { get; set; }

    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    string Username { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    string Password { get; set; }
}
