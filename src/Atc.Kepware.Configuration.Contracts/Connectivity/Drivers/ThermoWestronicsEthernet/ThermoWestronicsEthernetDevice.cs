namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.ThermoWestronicsEthernet;

/// <summary>
/// Thermo Westronics Ethernet device.
/// </summary>
public sealed class ThermoWestronicsEthernetDevice : DeviceBase, IThermoWestronicsEthernetDevice
{
    /// <inheritdoc />
    public string DeviceId { get; set; } = string.Empty;

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
    public int Port { get; set; }

    /// <inheritdoc />
    public int OutputCoils { get; set; }

    /// <inheritdoc />
    public int InputCoils { get; set; }

    /// <inheritdoc />
    public int InternalRegisters { get; set; }

    /// <inheritdoc />
    public int HoldingRegisters { get; set; }

    /// <inheritdoc />
    public bool Use1x32FloatFormat { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(DeviceId)}: {DeviceId}, {nameof(Port)}: {Port}";
}