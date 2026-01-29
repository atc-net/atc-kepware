namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.YokogawaDxpEthernet;

/// <summary>
/// Interface for Yokogawa DXP Ethernet device request.
/// </summary>
public interface IYokogawaDxpEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device model.
    /// </summary>
    YokogawaDxpEthernetModel Model { get; set; }

    /// <summary>
    /// Gets or sets the data handling for out of range and error conditions.
    /// </summary>
    YokogawaDxpEthernetDataHandling DataHandling { get; set; }

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
    YokogawaDxpEthernetDateTimeSource DateAndTime { get; set; }

    /// <summary>
    /// Gets or sets the date format for the return string.
    /// </summary>
    YokogawaDxpEthernetDateFormat DateFormat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to set the device clock on communication startup.
    /// </summary>
    bool SetClock { get; set; }

    /// <summary>
    /// Gets or sets the tag database generation source.
    /// </summary>
    YokogawaDxpEthernetTagDatabaseSource TagDatabaseSource { get; set; }

    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    string Username { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    string Password { get; set; }

    /// <summary>
    /// Gets or sets the user ID.
    /// </summary>
    string UserId { get; set; }

    /// <summary>
    /// Gets or sets the user function.
    /// </summary>
    YokogawaDxpEthernetUserFunction UserFunction { get; set; }
}