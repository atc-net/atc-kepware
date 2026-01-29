namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.ModbusTcpIpEthernet;

public interface IModbusTcpIpEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    ModbusDeviceModelType Model { get; set; }

    /// <summary>
    /// Indicate the format of the device ID.
    /// </summary>
    ModbusDeviceIdFormatType IdFormat { get; set; }

    /// <summary>
    /// Specify the device's driver-specific station or node.
    /// Format: &lt;IP_Address&gt;.&lt;Unit_ID&gt; (e.g., "192.168.1.1.1")
    /// </summary>
    string DeviceId { get; set; }

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
    /// Define how long, in milliseconds, the driver waits before sending the next request.
    /// </summary>
    int InterRequestDelayMs { get; set; }

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
    /// Select the automatic tag generation action to be taken on device startup.
    /// </summary>
    ModbusDeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <summary>
    /// Indicate the preferred method of avoiding creation of duplicate tags.
    /// </summary>
    ModbusDeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <summary>
    /// Indicate a tag group name for new generated tags.
    /// </summary>
    string? TagGenerationGroup { get; set; }

    /// <summary>
    /// Instruct the server to automatically create sub groups for automatically generated tags.
    /// </summary>
    bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <summary>
    /// Specify the port number that the remote device is configured to use.
    /// </summary>
    int Port { get; set; }

    /// <summary>
    /// Indicate whether the driver should use UDP or TCP/IP.
    /// </summary>
    ModbusDeviceIpProtocolType IpProtocol { get; set; }

    /// <summary>
    /// Enable the driver to close a TCP socket connection if a device does not respond within the timeout.
    /// </summary>
    bool CloseSocketOnTimeout { get; set; }

    /// <summary>
    /// Specify if the address numbering convention for the device starts at zero or one.
    /// </summary>
    bool ZeroBasedAddressing { get; set; }

    /// <summary>
    /// Specify if the first bit in a register address begins at zero or one.
    /// </summary>
    bool ZeroBasedBitAddressing { get; set; }

    /// <summary>
    /// Enable if the device supports holding register bit access.
    /// </summary>
    bool HoldingRegisterBitMaskWrites { get; set; }

    /// <summary>
    /// Enable if the device can use Modbus function 06 for single register writes.
    /// </summary>
    bool ModbusFunction06 { get; set; }

    /// <summary>
    /// Enable if the device can use Modbus function 05 for single coil writes.
    /// </summary>
    bool ModbusFunction05 { get; set; }

    /// <summary>
    /// Select Enable to use Modbus byte ordering or Disable to use Intel byte ordering.
    /// </summary>
    bool ModbusByteOrder { get; set; }

    /// <summary>
    /// Indicate if 32-bit data types use first word low convention.
    /// </summary>
    bool FirstWordLow { get; set; }

    /// <summary>
    /// Indicate if 64-bit data types use first DWord low convention.
    /// </summary>
    bool FirstDWordLow { get; set; }

    /// <summary>
    /// Indicate if the bit order should be reversed on register reads and writes.
    /// </summary>
    bool ModiconBitOrder { get; set; }

    /// <summary>
    /// Encode/decode Long and DWORD data types as double-precision 64-bit unsigned decimal values.
    /// </summary>
    bool TreatLongsAsDoubleDecimal { get; set; }

    /// <summary>
    /// Specify the number of coils (bits) in an output block.
    /// </summary>
    int OutputCoilsBlockSize { get; set; }

    /// <summary>
    /// Specify the number of coils (bits) in an input block.
    /// </summary>
    int InputCoilsBlockSize { get; set; }

    /// <summary>
    /// Specify the block size for internal registers.
    /// </summary>
    int InternalRegistersBlockSize { get; set; }

    /// <summary>
    /// Specify the block size for holding registers.
    /// </summary>
    int HoldingRegistersBlockSize { get; set; }
}