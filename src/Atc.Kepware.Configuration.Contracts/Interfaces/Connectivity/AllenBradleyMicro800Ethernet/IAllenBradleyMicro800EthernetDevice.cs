namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AllenBradleyMicro800Ethernet;

public interface IAllenBradleyMicro800EthernetDevice : IDeviceBase
{
    /// <summary>
    /// The device ID (IP address or hostname).
    /// </summary>
    string DeviceId { get; set; }

    /// <summary>
    /// Set the port number for the target device.
    /// </summary>
    /// <remarks>
    /// Range: 0-65535, Default: 44818.
    /// </remarks>
    int Port { get; set; }

    /// <summary>
    /// Specify the amount of time, in seconds, a connection can remain idle before being closed by the controller.
    /// </summary>
    Micro800InactivityWatchdogType InactivityWatchdog { get; set; }

    /// <summary>
    /// Select the data type to assign to a tag when the default type is selected.
    /// </summary>
    Micro800DefaultDataType DefaultDataType { get; set; }

    /// <summary>
    /// Specify the maximum number of atomic array elements to read in a single transaction.
    /// </summary>
    /// <remarks>
    /// Range: 30-3840, Default: 120.
    /// </remarks>
    int ArrayBlockSize { get; set; }
}
