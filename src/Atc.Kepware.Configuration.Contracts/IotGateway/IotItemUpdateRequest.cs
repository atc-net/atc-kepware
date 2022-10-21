namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public class IotItemUpdateRequest : IIotItemUpdateRequest
{
    /// <inheritdoc />
    public long ProjectId { get; set; }

    /// <inheritdoc />
    public int? ScanRate { get; set; }

    /// <inheritdoc />
    public bool? SendEveryScan { get; set; }

    /// <inheritdoc />
    public int? DeadBandPercent { get; set; }

    /// <inheritdoc />
    public bool? Enabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ProjectId)}: {ProjectId}, {nameof(ScanRate)}: {ScanRate}, {nameof(SendEveryScan)}: {SendEveryScan}, {nameof(DeadBandPercent)}: {DeadBandPercent}, {nameof(Enabled)}: {Enabled}";
}