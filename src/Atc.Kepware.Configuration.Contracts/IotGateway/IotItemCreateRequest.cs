namespace Atc.Kepware.Configuration.Contracts.IotGateway;

public sealed class IotItemCreateRequest : IIotItemCreateRequest
{
    /// <inheritdoc />
    public string ServerTag { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(100, 60000)]
    public int ScanRate { get; set; } = 10000;

    /// <inheritdoc />
    public bool SendEveryScan { get; set; }

    /// <inheritdoc />
    public int DeadBandPercent { get; set; }

    /// <inheritdoc />
    public bool Enabled { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(ServerTag)}: {ServerTag}, {nameof(ScanRate)}: {ScanRate}, {nameof(SendEveryScan)}: {SendEveryScan}, {nameof(DeadBandPercent)}: {DeadBandPercent}, {nameof(Enabled)}: {Enabled}";
}