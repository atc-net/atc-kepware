namespace Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.Iec608705104Client;

/// <summary>
/// Represents an IEC 60870-5-104 Client device creation request.
/// </summary>
public class Iec608705104ClientDeviceRequest : DeviceRequestBase, IIec608705104ClientDeviceRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Iec608705104ClientDeviceRequest"/> class.
    /// </summary>
    public Iec608705104ClientDeviceRequest()
        : base(DriverType.Iec608705104Client)
    {
    }

    /// <inheritdoc />
    [Range(0, 65534)]
    public int CommonAddress { get; set; } = 3;

    /// <inheritdoc />
    public bool PolledReads { get; set; } = true;

    /// <inheritdoc />
    [Range(1, int.MaxValue)]
    public int RequestTimeout { get; set; } = 10000;

    /// <inheritdoc />
    [Range(1, int.MaxValue)]
    public int InterrogationRequestTimeout { get; set; } = 60000;

    /// <inheritdoc />
    [Range(1, 10)]
    public int AttemptCount { get; set; } = 3;

    /// <inheritdoc />
    [Range(1, 10)]
    public int InterrogationAttemptCount { get; set; } = 3;

    /// <inheritdoc />
    public Iec608705104InitializationType TimeSyncInitialization { get; set; } = Iec608705104InitializationType.EndOfInitialization;

    /// <inheritdoc />
    public Iec608705104InitializationType GiInitialization { get; set; } = Iec608705104InitializationType.EndOfInitialization;

    /// <inheritdoc />
    public Iec608705104InitializationType CiInitialization { get; set; } = Iec608705104InitializationType.EndOfInitialization;

    /// <inheritdoc />
    [Range(0, int.MaxValue)]
    public int PeriodicGiInterval { get; set; } = 720;

    /// <inheritdoc />
    [Range(0, int.MaxValue)]
    public int PeriodicCiInterval { get; set; }

    /// <inheritdoc />
    public bool TestProcedure { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 86400)]
    public int TestProcedurePeriod { get; set; } = 15;

    /// <inheritdoc />
    public bool PlaybackEvents { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 10000)]
    public int PlaybackBufferSize { get; set; } = 100;

    /// <inheritdoc />
    [Range(50, 10000)]
    public int PlaybackRate { get; set; } = 2000;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(CommonAddress)}: {CommonAddress}";
}
