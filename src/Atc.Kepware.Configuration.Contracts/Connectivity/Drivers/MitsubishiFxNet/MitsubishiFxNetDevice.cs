namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net device.
/// </summary>
public class MitsubishiFxNetDevice : DeviceBase, IMitsubishiFxNetDevice
{
    /// <inheritdoc />
    public MitsubishiFxNetModel Model { get; set; } = MitsubishiFxNetModel.Fx;

    /// <inheritdoc />
    public int DeviceId { get; set; }

    /// <inheritdoc />
    public string IpAddress { get; set; } = string.Empty;

    /// <inheritdoc />
    public int Port { get; set; } = 2101;

    /// <inheritdoc />
    public MitsubishiFxNetProtocolType Protocol { get; set; } = MitsubishiFxNetProtocolType.TcpIp;

    /// <inheritdoc />
    public int ConnectTimeout { get; set; } = 3;

    /// <inheritdoc />
    public int RequestTimeout { get; set; } = 1000;

    /// <inheritdoc />
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    public int DemotionPeriod { get; set; } = 10000;

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(IpAddress)}: {IpAddress}";
}
