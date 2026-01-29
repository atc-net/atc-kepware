namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Iec608705104Client;

/// <summary>
/// Device request properties for the IEC 60870-5-104 Client driver.
/// </summary>
internal sealed class Iec608705104ClientDeviceRequest : DeviceRequestBase, IIec608705104ClientDeviceRequest
{
    public Iec608705104ClientDeviceRequest()
        : base(DriverType.Iec608705104Client)
    {
    }

    /// <inheritdoc />
    [Range(0, 65534)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_COMMON_ADDRESS")]
    public int CommonAddress { get; set; } = 3;

    /// <inheritdoc />
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_POLLED_READS")]
    public bool PolledReads { get; set; } = true;

    /// <inheritdoc />
    [Range(1, int.MaxValue)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_REQUEST_TIMEOUT")]
    public int RequestTimeout { get; set; } = 10000;

    /// <inheritdoc />
    [Range(1, int.MaxValue)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_INTERROGATION_REQUEST_TIMEOUT")]
    public int InterrogationRequestTimeout { get; set; } = 60000;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_ATTEMPT_COUNT")]
    public int AttemptCount { get; set; } = 3;

    /// <inheritdoc />
    [Range(1, 10)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_INTERROGATION_ATTEMPT_COUNT")]
    public int InterrogationAttemptCount { get; set; } = 3;

    /// <inheritdoc />
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_TIME_SYNC_INITIALIZATION")]
    public Iec608705104InitializationType TimeSyncInitialization { get; set; } = Iec608705104InitializationType.EndOfInitialization;

    /// <inheritdoc />
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_GI_INITIALIZATION")]
    public Iec608705104InitializationType GiInitialization { get; set; } = Iec608705104InitializationType.EndOfInitialization;

    /// <inheritdoc />
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_CI_INITIALIZATION")]
    public Iec608705104InitializationType CiInitialization { get; set; } = Iec608705104InitializationType.EndOfInitialization;

    /// <inheritdoc />
    [Range(0, int.MaxValue)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PERIODIC_GI_INTERVAL")]
    public int PeriodicGiInterval { get; set; } = 720;

    /// <inheritdoc />
    [Range(0, int.MaxValue)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PERIODIC_CI_INTERVAL")]
    public int PeriodicCiInterval { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_TEST_PROCEDURE")]
    public bool TestProcedure { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 86400)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_TEST_PROCEDURE_PERIOD")]
    public int TestProcedurePeriod { get; set; } = 15;

    /// <inheritdoc />
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PLAYBACK_EVENTS")]
    public bool PlaybackEvents { get; set; } = true;

    /// <inheritdoc />
    [Range(1, 10000)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PLAYBACK_BUFFER_SIZE")]
    public int PlaybackBufferSize { get; set; } = 100;

    /// <inheritdoc />
    [Range(50, 10000)]
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PLAYBACK_RATE")]
    public int PlaybackRate { get; set; } = 2000;

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(CommonAddress)}: {CommonAddress}";
}