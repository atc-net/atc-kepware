namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyBulletin900;

/// <summary>
/// Device request properties for the Allen-Bradley Bulletin 900 driver.
/// </summary>
public sealed class AllenBradleyBulletin900DeviceRequest : DeviceRequestBase, IAllenBradleyBulletin900DeviceRequest
{
    public AllenBradleyBulletin900DeviceRequest()
        : base(DriverType.AllenBradleyBulletin900)
    {
    }

    /// <inheritdoc />
    public Bulletin900DeviceModelType Model { get; set; } = Bulletin900DeviceModelType.Tc8;

    /// <inheritdoc />
    [Range(0, 99)]
    public int DeviceId { get; set; } = 1;

    /// <inheritdoc />
    [MaxLength(15)]
    public string? IpAddress { get; set; }

    /// <inheritdoc />
    [Range(0, 65535)]
    public int EthernetPort { get; set; } = 2101;

    /// <inheritdoc />
    public Bulletin900EthernetProtocolType EthernetProtocol { get; set; } = Bulletin900EthernetProtocolType.TcpIp;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(200, 9999999)]
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
    public DeviceTagGenerationOnStartupType TagGenerationOnStartup { get; set; } = DeviceTagGenerationOnStartupType.DoNotGenerateOnStartup;

    /// <inheritdoc />
    public DeviceTagGenerationDuplicateHandlingType TagGenerationDuplicateHandling { get; set; } = DeviceTagGenerationDuplicateHandlingType.DeleteOnCreate;

    /// <inheritdoc />
    [MaxLength(256)]
    public string? TagGenerationGroup { get; set; }

    /// <inheritdoc />
    public bool AllowAutomaticallyGeneratedSubgroups { get; set; } = true;

    /// <inheritdoc />
    public bool ProcessValueScaling { get; set; }

    /// <inheritdoc />
    [Range(0.1f, 1000f)]
    public float ProcessValueScalingFactor { get; set; } = 10f;

    /// <inheritdoc />
    public Bulletin900InputType InputType { get; set; } = Bulletin900InputType.TcPtMultiInput;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}";
}