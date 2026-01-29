namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AlstomRedundantEthernet;

/// <summary>
/// Device properties for the Alstom Redundant Ethernet driver.
/// </summary>
public sealed class AlstomRedundantEthernetDevice : DeviceBase, IAlstomRedundantEthernetDevice
{
    /// <inheritdoc />
    public AlstomRedundantEthernetDeviceModel Model { get; set; }

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; }

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; }

    /// <inheritdoc />
    public int RetryAttempts { get; set; }

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    public int TimeoutsToDemote { get; set; }

    /// <inheritdoc />
    public int DemotionPeriodMs { get; set; }

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public string PrimaryNormalIp { get; set; } = string.Empty;

    /// <inheritdoc />
    public int PrimaryNormalPort { get; set; }

    /// <inheritdoc />
    public string PrimaryStandbyIp { get; set; } = string.Empty;

    /// <inheritdoc />
    public int PrimaryStandbyPort { get; set; }

    /// <inheritdoc />
    public string SecondaryNormalIp { get; set; } = string.Empty;

    /// <inheritdoc />
    public int SecondaryNormalPort { get; set; }

    /// <inheritdoc />
    public string SecondaryStandbyIp { get; set; } = string.Empty;

    /// <inheritdoc />
    public int SecondaryStandbyPort { get; set; }

    /// <inheritdoc />
    public int OutputCoilsBlockSize { get; set; }

    /// <inheritdoc />
    public int InputCoilsBlockSize { get; set; }

    /// <inheritdoc />
    public int InternalRegistersBlockSize { get; set; }

    /// <inheritdoc />
    public int HoldingRegistersBlockSize { get; set; }

    /// <inheritdoc />
    public int InvalidSequenceNumbersBeforeReset { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(PrimaryNormalIp)}: {PrimaryNormalIp}, {nameof(PrimaryNormalPort)}: {PrimaryNormalPort}";
}