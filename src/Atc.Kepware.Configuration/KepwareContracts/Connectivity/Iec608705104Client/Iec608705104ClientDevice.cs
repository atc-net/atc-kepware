namespace Atc.Kepware.Configuration.KepwareContracts.Connectivity.Iec608705104Client;

/// <summary>
/// Device properties for the IEC 60870-5-104 Client driver.
/// </summary>
internal sealed class Iec608705104ClientDevice : DeviceBase, IIec608705104ClientDevice
{
    [JsonPropertyName("iec_60870_5_104_master.DEVICE_COMMON_ADDRESS")]
    public int CommonAddress { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_POLLED_READS")]
    public bool PolledReads { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_REQUEST_TIMEOUT")]
    public int RequestTimeout { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_INTERROGATION_REQUEST_TIMEOUT")]
    public int InterrogationRequestTimeout { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_ATTEMPT_COUNT")]
    public int AttemptCount { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_INTERROGATION_ATTEMPT_COUNT")]
    public int InterrogationAttemptCount { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_TIME_SYNC_INITIALIZATION")]
    public Iec608705104InitializationType TimeSyncInitialization { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_GI_INITIALIZATION")]
    public Iec608705104InitializationType GiInitialization { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_CI_INITIALIZATION")]
    public Iec608705104InitializationType CiInitialization { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PERIODIC_GI_INTERVAL")]
    public int PeriodicGiInterval { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PERIODIC_CI_INTERVAL")]
    public int PeriodicCiInterval { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_TEST_PROCEDURE")]
    public bool TestProcedure { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_TEST_PROCEDURE_PERIOD")]
    public int TestProcedurePeriod { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PLAYBACK_EVENTS")]
    public bool PlaybackEvents { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PLAYBACK_BUFFER_SIZE")]
    public int PlaybackBufferSize { get; set; }

    [JsonPropertyName("iec_60870_5_104_master.DEVICE_PLAYBACK_RATE")]
    public int PlaybackRate { get; set; }

    public override string ToString()
        => $"{base.ToString()}, {nameof(CommonAddress)}: {CommonAddress}";
}
