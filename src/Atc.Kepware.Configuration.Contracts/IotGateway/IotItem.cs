namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotItem : IIotItem
{
    /// <inheritdoc />
    public long ProjectId { get; set; }

    /// <inheritdoc />
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc />
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc />
    public string ServerTag { get; set; } = string.Empty;

    /// <inheritdoc />
    public bool UsesScanRate { get; set; }

    /// <inheritdoc />
    public int ScanRate { get; set; }

    /// <inheritdoc />
    public bool SendEveryScan { get; set; }

    /// <inheritdoc />
    public int DeadBandPercent { get; set; }

    /// <inheritdoc />
    public bool Enabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ProjectId)}: {ProjectId}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(ServerTag)}: {ServerTag}, {nameof(UsesScanRate)}: {UsesScanRate}, {nameof(ScanRate)}: {ScanRate}, {nameof(SendEveryScan)}: {SendEveryScan}, {nameof(DeadBandPercent)}: {DeadBandPercent}, {nameof(Enabled)}: {Enabled}";
}