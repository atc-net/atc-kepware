namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyBulletin1609;

/// <summary>
/// Device properties for the Allen-Bradley Bulletin 1609 driver (response).
/// </summary>
public sealed class AllenBradleyBulletin1609Device : DeviceBase
{
    /// <summary>
    /// Select the specific type of device associated with this ID.
    /// </summary>
    public Bulletin1609DeviceModelType Model { get; set; }

    /// <summary>
    /// Specify the device's driver-specific station or node (IP address).
    /// </summary>
    public string DeviceId { get; set; } = string.Empty;

    /// <summary>
    /// Define the maximum amount of time, in seconds, allowed to establish a connection to a remote device.
    /// </summary>
    public int ConnectTimeoutSeconds { get; set; }

    /// <summary>
    /// Specify an interval, in milliseconds, to determine how long the driver waits for a response.
    /// </summary>
    public int RequestTimeoutMs { get; set; }

    /// <summary>
    /// Indicate how many times the driver sends a communications request before considering it failed.
    /// </summary>
    public int RetryAttempts { get; set; }

    /// <summary>
    /// Automatically remove the device from the scan due to communication failures.
    /// </summary>
    public bool DemoteOnFailure { get; set; }

    /// <summary>
    /// Specify how many successive cycles of request timeouts occur before the device is placed off-scan.
    /// </summary>
    public int TimeoutsToDemote { get; set; }

    /// <summary>
    /// Indicate how long, in milliseconds, before scanning is attempted again on a demoted device.
    /// </summary>
    public int DemotionPeriodMs { get; set; }

    /// <summary>
    /// Select whether write requests are discarded during the off-scan period.
    /// </summary>
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <summary>
    /// Controls whether this device will automatically generate new tags whenever certain properties are changed.
    /// </summary>
    public bool TagGenerationOnPropertyChange { get; set; }

    /// <summary>
    /// Select the automatic tag generation action to be taken on device startup.
    /// </summary>
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; }

    /// <summary>
    /// Indicate the preferred method of avoiding creation of duplicate tags.
    /// </summary>
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; }

    /// <summary>
    /// Indicate a tag group name for new generated tags.
    /// </summary>
    public string? TagGenerationGroup { get; set; }

    /// <summary>
    /// Instruct the server to automatically create sub groups for automatically generated tags.
    /// </summary>
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; }

    /// <summary>
    /// Set the UDP or TCP/IP port number the device is configured to use.
    /// </summary>
    public int Port { get; set; }

    /// <summary>
    /// Select the Ethernet protocol used by the device.
    /// </summary>
    public Bulletin1609IpProtocolType IpProtocol { get; set; }

    /// <summary>
    /// Select the community for the tags that are not pre-configured in the driver.
    /// </summary>
    public Bulletin1609CommunityType Community { get; set; }

    /// <summary>
    /// Specify the custom community to use for tags that are not-preconfigured in the driver.
    /// </summary>
    public string? CustomCommunity { get; set; }

    /// <summary>
    /// Determine the maximum number of items to be requested per SNMP request.
    /// </summary>
    public int NumberOfItemsPerMessage { get; set; }

    /// <summary>
    /// Specify if the driver should post error messages for auto-generated tags that do not exist in the device.
    /// </summary>
    public bool PostErrorsForNonExistingTags { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}