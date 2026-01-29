namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.TriconexEthernet;

/// <summary>
/// Represents a Triconex Ethernet device creation request.
/// </summary>
public class TriconexEthernetDeviceRequest : DeviceRequestBase, ITriconexEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TriconexEthernetDeviceRequest"/> class.
    /// </summary>
    public TriconexEthernetDeviceRequest()
        : base(DriverType.TriconexEthernet)
    {
    }

    /// <inheritdoc />
    [Required]
    [Range(1, 63)]
    public int DeviceId { get; set; } = 1;

    /// <inheritdoc />
    [Required]
    public string PrimaryNetworkCmIp { get; set; } = "0.0.0.0";

    /// <inheritdoc />
    public string? SecondaryNetworkCmIp { get; set; } = "0.0.0.0";

    /// <inheritdoc />
    [Range(50, 10000)]
    public int BinDataUpdatePeriod { get; set; } = 1000;

    /// <inheritdoc />
    [Range(10, 120)]
    public int SubscriptionInterval { get; set; } = 10;

    /// <inheritdoc />
    public bool UseTimestampFromDevice { get; set; }

    /// <inheritdoc />
    public string? VariableImportFile { get; set; }

    /// <inheritdoc />
    public string? ImportNodeName { get; set; } = "TRINODE";

    /// <inheritdoc />
    public bool GenerateDeviceSystemTags { get; set; }

    /// <inheritdoc />
    public bool GenerateDriverSystemTags { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(PrimaryNetworkCmIp)}: {PrimaryNetworkCmIp}, {nameof(SecondaryNetworkCmIp)}: {SecondaryNetworkCmIp}, {nameof(BinDataUpdatePeriod)}: {BinDataUpdatePeriod}, {nameof(SubscriptionInterval)}: {SubscriptionInterval}";
}
