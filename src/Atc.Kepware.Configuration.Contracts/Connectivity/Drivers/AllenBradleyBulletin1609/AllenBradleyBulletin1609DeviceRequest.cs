namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.AllenBradleyBulletin1609;

/// <summary>
/// Device request properties for the Allen-Bradley Bulletin 1609 driver.
/// </summary>
public sealed class AllenBradleyBulletin1609DeviceRequest : DeviceRequestBase, IAllenBradleyBulletin1609DeviceRequest
{
    public AllenBradleyBulletin1609DeviceRequest()
        : base(DriverType.AllenBradleyBulletin1609)
    {
    }

    /// <inheritdoc />
    public Bulletin1609DeviceModelType Model { get; set; } = Bulletin1609DeviceModelType.Bulletin1609Ups;

    /// <inheritdoc />
    [Required]
    public string DeviceId { get; set; } = "255.255.255.255";

    /// <inheritdoc />
    [Range(1, 60)]
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999)]
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
    public bool TagGenerationOnPropertyChange { get; set; } = true;

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
    [Range(1, 65530)]
    public int Port { get; set; } = 161;

    /// <inheritdoc />
    public Bulletin1609IpProtocolType IpProtocol { get; set; } = Bulletin1609IpProtocolType.Udp;

    /// <inheritdoc />
    public Bulletin1609CommunityType Community { get; set; } = Bulletin1609CommunityType.Private;

    /// <inheritdoc />
    [MaxLength(15)]
    public string? CustomCommunity { get; set; }

    /// <inheritdoc />
    [Range(1, 25)]
    public int NumberOfItemsPerMessage { get; set; } = 25;

    /// <inheritdoc />
    public bool PostErrorsForNonExistingTags { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
