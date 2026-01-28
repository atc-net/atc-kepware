namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.AlstomRedundantEthernet;

/// <summary>
/// Interface for Alstom Redundant Ethernet device request properties.
/// </summary>
public interface IAlstomRedundantEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    AlstomRedundantEthernetDeviceModel Model { get; set; }

    /// <summary>
    /// Define the maximum amount of time, in seconds, allowed to establish a connection to a remote device.
    /// </summary>
    int ConnectTimeoutSeconds { get; set; }

    /// <summary>
    /// Specify an interval, in milliseconds, to determine how long the driver waits for a response.
    /// </summary>
    int RequestTimeoutMs { get; set; }

    /// <summary>
    /// Indicate how many times the driver sends a communications request before considering it failed.
    /// </summary>
    int RetryAttempts { get; set; }

    /// <summary>
    /// Automatically remove the device from the scan due to communication failures.
    /// </summary>
    bool DemoteOnFailure { get; set; }

    /// <summary>
    /// Specify how many successive cycles of request timeouts occur before the device is placed off-scan.
    /// </summary>
    int TimeoutsToDemote { get; set; }

    /// <summary>
    /// Indicate how long, in milliseconds, before scanning is attempted again on a demoted device.
    /// </summary>
    int DemotionPeriodMs { get; set; }

    /// <summary>
    /// Select whether write requests are discarded during the off-scan period.
    /// </summary>
    bool DiscardRequestsWhenDemoted { get; set; }

    /// <summary>
    /// Specify the normal IP address for the primary device.
    /// </summary>
    string PrimaryNormalIp { get; set; }

    /// <summary>
    /// Specify the normal port for the primary device.
    /// </summary>
    int PrimaryNormalPort { get; set; }

    /// <summary>
    /// Specify the standby IP address for the primary device.
    /// </summary>
    string PrimaryStandbyIp { get; set; }

    /// <summary>
    /// Specify the standby port for the primary device.
    /// </summary>
    int PrimaryStandbyPort { get; set; }

    /// <summary>
    /// Specify the normal IP address for the secondary device.
    /// </summary>
    string SecondaryNormalIp { get; set; }

    /// <summary>
    /// Specify the normal port for the secondary device.
    /// </summary>
    int SecondaryNormalPort { get; set; }

    /// <summary>
    /// Specify the standby IP address for the secondary device.
    /// </summary>
    string SecondaryStandbyIp { get; set; }

    /// <summary>
    /// Specify the standby port for the secondary device.
    /// </summary>
    int SecondaryStandbyPort { get; set; }

    /// <summary>
    /// Specify the maximum block size to use when reading output coils.
    /// </summary>
    int OutputCoilsBlockSize { get; set; }

    /// <summary>
    /// Specify the maximum block size to use when reading input coils.
    /// </summary>
    int InputCoilsBlockSize { get; set; }

    /// <summary>
    /// Specify the maximum block size to use when reading internal registers.
    /// </summary>
    int InternalRegistersBlockSize { get; set; }

    /// <summary>
    /// Specify the maximum block size to use when reading holding registers.
    /// </summary>
    int HoldingRegistersBlockSize { get; set; }

    /// <summary>
    /// Specify the number of consecutive packets with an invalid sequence number that the driver ignores before resetting the sequence number.
    /// </summary>
    int InvalidSequenceNumbersBeforeReset { get; set; }
}
