namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AlstomRedundantEthernet;

/// <summary>
/// Device request properties for the Alstom Redundant Ethernet driver.
/// </summary>
public sealed class AlstomRedundantEthernetDeviceRequest : DeviceRequestBase, IAlstomRedundantEthernetDeviceRequest
{
    public AlstomRedundantEthernetDeviceRequest()
        : base(DriverType.AlstomRedundantEthernet)
    {
    }

    /// <inheritdoc />
    public AlstomRedundantEthernetDeviceModel Model { get; set; } = AlstomRedundantEthernetDeviceModel.IVpi;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    [Range(100, 3600000)]
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    public string PrimaryNormalIp { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PrimaryNormalPort { get; set; } = 502;

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    public string PrimaryStandbyIp { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int PrimaryStandbyPort { get; set; } = 502;

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    public string SecondaryNormalIp { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int SecondaryNormalPort { get; set; } = 1502;

    /// <inheritdoc />
    [Required]
    [MaxLength(15)]
    public string SecondaryStandbyIp { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(0, 65535)]
    public int SecondaryStandbyPort { get; set; } = 1502;

    /// <inheritdoc />
    [Range(8, 2000)]
    public int OutputCoilsBlockSize { get; set; } = 8;

    /// <inheritdoc />
    [Range(8, 2000)]
    public int InputCoilsBlockSize { get; set; } = 8;

    /// <inheritdoc />
    [Range(1, 120)]
    public int InternalRegistersBlockSize { get; set; } = 1;

    /// <inheritdoc />
    [Range(1, 120)]
    public int HoldingRegistersBlockSize { get; set; } = 1;

    /// <inheritdoc />
    [Range(1, 5)]
    public int InvalidSequenceNumbersBeforeReset { get; set; } = 5;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(PrimaryNormalIp)}: {PrimaryNormalIp}, {nameof(PrimaryNormalPort)}: {PrimaryNormalPort}";
}