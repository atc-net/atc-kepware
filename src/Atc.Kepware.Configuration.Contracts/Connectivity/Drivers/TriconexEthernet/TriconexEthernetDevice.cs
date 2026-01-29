namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.TriconexEthernet;

/// <summary>
/// Represents a Triconex Ethernet device.
/// </summary>
public class TriconexEthernetDevice : DeviceBase, ITriconexEthernetDevice
{
    /// <inheritdoc />
    public int DeviceId { get; set; } = 1;

    /// <inheritdoc />
    public string PrimaryNetworkCmIp { get; set; } = "0.0.0.0";

    /// <inheritdoc />
    public string? SecondaryNetworkCmIp { get; set; } = "0.0.0.0";

    /// <inheritdoc />
    public int BinDataUpdatePeriod { get; set; } = 1000;

    /// <inheritdoc />
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
