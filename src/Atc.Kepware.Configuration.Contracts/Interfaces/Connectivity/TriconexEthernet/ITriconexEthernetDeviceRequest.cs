namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.TriconexEthernet;

/// <summary>
/// Defines the Triconex Ethernet device request properties.
/// </summary>
public interface ITriconexEthernetDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the device node ID.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-63. Default: 1.
    /// </remarks>
    int DeviceId { get; set; }

    /// <summary>
    /// Gets or sets the IP address of the communications module on the primary network.
    /// </summary>
    /// <remarks>
    /// Default value is "0.0.0.0".
    /// </remarks>
    string PrimaryNetworkCmIp { get; set; }

    /// <summary>
    /// Gets or sets the IP address of the communications module on the secondary network.
    /// </summary>
    /// <remarks>
    /// Default value is "0.0.0.0".
    /// </remarks>
    string? SecondaryNetworkCmIp { get; set; }

    /// <summary>
    /// Gets or sets the bin data update period in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 50-10000. Default: 1000.
    /// </remarks>
    int BinDataUpdatePeriod { get; set; }

    /// <summary>
    /// Gets or sets the subscription renewal interval in seconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 10-120. Default: 10.
    /// </remarks>
    int SubscriptionInterval { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to use the timestamp from the device.
    /// </summary>
    /// <remarks>
    /// Supported by Trident devices only. Default: false.
    /// </remarks>
    bool UseTimestampFromDevice { get; set; }

    /// <summary>
    /// Gets or sets the path to the TriStation export file for automatic tag generation.
    /// </summary>
    string? VariableImportFile { get; set; }

    /// <summary>
    /// Gets or sets the node name for tags that will be imported.
    /// </summary>
    /// <remarks>
    /// Default value is "TRINODE".
    /// </remarks>
    string? ImportNodeName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to generate device system tags.
    /// </summary>
    /// <remarks>
    /// Enabled for Tricon model only. Default: false.
    /// </remarks>
    bool GenerateDeviceSystemTags { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to generate driver system tags.
    /// </summary>
    /// <remarks>
    /// Default: false.
    /// </remarks>
    bool GenerateDriverSystemTags { get; set; }
}