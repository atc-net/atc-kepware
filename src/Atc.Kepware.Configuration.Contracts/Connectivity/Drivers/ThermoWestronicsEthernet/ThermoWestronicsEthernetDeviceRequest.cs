namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ThermoWestronicsEthernet;

/// <summary>
/// Thermo Westronics Ethernet device request.
/// </summary>
public sealed class ThermoWestronicsEthernetDeviceRequest : DeviceRequestBase, IThermoWestronicsEthernetDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ThermoWestronicsEthernetDeviceRequest"/> class.
    /// </summary>
    public ThermoWestronicsEthernetDeviceRequest()
        : base(DriverType.ThermoWestronicsEthernet)
    {
    }

    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public int ConnectTimeoutSeconds { get; set; } = 3;

    /// <inheritdoc />
    public int RequestTimeoutMs { get; set; } = 1000;

    /// <inheritdoc />
    public int RetryAttempts { get; set; } = 3;

    /// <inheritdoc />
    public bool DemoteOnFailure { get; set; }

    /// <inheritdoc />
    public int TimeoutsToDemote { get; set; } = 3;

    /// <inheritdoc />
    public int DemotionPeriodMs { get; set; } = 10000;

    /// <inheritdoc />
    public bool DiscardRequestsWhenDemoted { get; set; }

    /// <inheritdoc />
    public int Port { get; set; } = 502;

    /// <inheritdoc />
    public int OutputCoils { get; set; } = 32;

    /// <inheritdoc />
    public int InputCoils { get; set; } = 32;

    /// <inheritdoc />
    public int InternalRegisters { get; set; } = 32;

    /// <inheritdoc />
    public int HoldingRegisters { get; set; } = 32;

    /// <inheritdoc />
    public bool Use1x32FloatFormat { get; set; } = true;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}
