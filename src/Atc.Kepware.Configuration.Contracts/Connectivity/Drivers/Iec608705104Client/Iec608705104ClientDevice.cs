namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Iec608705104Client;

/// <summary>
/// Represents an IEC 60870-5-104 Client device.
/// </summary>
public class Iec608705104ClientDevice : DeviceBase, IIec608705104ClientDevice
{
    /// <inheritdoc />
    public int CommonAddress { get; set; }

    /// <inheritdoc />
    public bool PolledReads { get; set; }

    /// <inheritdoc />
    public int RequestTimeout { get; set; }

    /// <inheritdoc />
    public int InterrogationRequestTimeout { get; set; }

    /// <inheritdoc />
    public int AttemptCount { get; set; }

    /// <inheritdoc />
    public int InterrogationAttemptCount { get; set; }

    /// <inheritdoc />
    public Iec608705104InitializationType TimeSyncInitialization { get; set; }

    /// <inheritdoc />
    public Iec608705104InitializationType GiInitialization { get; set; }

    /// <inheritdoc />
    public Iec608705104InitializationType CiInitialization { get; set; }

    /// <inheritdoc />
    public int PeriodicGiInterval { get; set; }

    /// <inheritdoc />
    public int PeriodicCiInterval { get; set; }

    /// <inheritdoc />
    public bool TestProcedure { get; set; }

    /// <inheritdoc />
    public int TestProcedurePeriod { get; set; }

    /// <inheritdoc />
    public bool PlaybackEvents { get; set; }

    /// <inheritdoc />
    public int PlaybackBufferSize { get; set; }

    /// <inheritdoc />
    public int PlaybackRate { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(CommonAddress)}: {CommonAddress}";
}
