namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.MitsubishiFxNet;

/// <summary>
/// Mitsubishi FX Net device request.
/// </summary>
public class MitsubishiFxNetDeviceRequest : DeviceRequestBase, IMitsubishiFxNetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MitsubishiFxNetDeviceRequest"/> class.
    /// </summary>
    public MitsubishiFxNetDeviceRequest()
        : base(DriverType.MitsubishiFxNet)
    {
    }

    /// <inheritdoc />
    public MitsubishiFxNetModel Model { get; set; } = MitsubishiFxNetModel.Fx;

    /// <inheritdoc />
    [Range(0, 15)]
    public int DeviceId { get; set; }

    /// <inheritdoc />
    public string IpAddress { get; set; } = string.Empty;

    /// <inheritdoc />
    [Range(0, 65535)]
    public int Port { get; set; } = 2101;

    /// <inheritdoc />
    public MitsubishiFxNetProtocolType Protocol { get; set; } = MitsubishiFxNetProtocolType.TcpIp;

    /// <inheritdoc />
    [Range(1, 30)]
    public int ConnectTimeout { get; set; } = 3;

    /// <inheritdoc />
    [Range(50, 9999999)]
    public int RequestTimeout { get; set; } = 1000;

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
    public int DemotionPeriod { get; set; } = 10000;

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Model)}: {Model}, {nameof(DeviceId)}: {DeviceId}, {nameof(IpAddress)}: {IpAddress}";
}