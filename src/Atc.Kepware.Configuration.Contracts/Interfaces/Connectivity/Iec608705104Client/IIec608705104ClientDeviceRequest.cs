namespace Atc.Kepware.Configuration.Contracts.Interfaces.Connectivity.Iec608705104Client;

/// <summary>
/// Defines the IEC 60870-5-104 Client device request properties.
/// </summary>
public interface IIec608705104ClientDeviceRequest : IDeviceRequestBase
{
    /// <summary>
    /// Gets or sets the Common Address for the device.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-65534. Default: 3.
    /// </remarks>
    int CommonAddress { get; set; }

    /// <summary>
    /// Gets or sets whether unbuffered tags will perform polled reads when last-read data is older than the scan rate.
    /// </summary>
    /// <remarks>
    /// When disabled, only previously received cyclic and background scan data will be reported.
    /// </remarks>
    bool PolledReads { get; set; }

    /// <summary>
    /// Gets or sets the request timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-2147483647. Default: 10000.
    /// </remarks>
    int RequestTimeout { get; set; }

    /// <summary>
    /// Gets or sets the interrogation request timeout in milliseconds.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-2147483647. Default: 60000.
    /// </remarks>
    int InterrogationRequestTimeout { get; set; }

    /// <summary>
    /// Gets or sets the number of times the driver attempts basic communication.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-10. Default: 3.
    /// </remarks>
    int AttemptCount { get; set; }

    /// <summary>
    /// Gets or sets the number of times the driver attempts general or counter interrogation.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-10. Default: 3.
    /// </remarks>
    int InterrogationAttemptCount { get; set; }

    /// <summary>
    /// Gets or sets when the IEC 60870-5-104 client should send Time Syncs.
    /// </summary>
    /// <remarks>
    /// Default: EndOfInitialization.
    /// </remarks>
    Iec608705104InitializationType TimeSyncInitialization { get; set; }

    /// <summary>
    /// Gets or sets when the IEC 60870-5-104 client should send General Interrogations.
    /// </summary>
    /// <remarks>
    /// Default: EndOfInitialization.
    /// </remarks>
    Iec608705104InitializationType GiInitialization { get; set; }

    /// <summary>
    /// Gets or sets when the IEC 60870-5-104 client should send Counter Interrogations.
    /// </summary>
    /// <remarks>
    /// Default: EndOfInitialization.
    /// </remarks>
    Iec608705104InitializationType CiInitialization { get; set; }

    /// <summary>
    /// Gets or sets the interval in minutes to send a General Interrogation.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-2147483647. Default: 720. A value of 0 disables this feature.
    /// </remarks>
    int PeriodicGiInterval { get; set; }

    /// <summary>
    /// Gets or sets the interval in minutes to send a Counter Interrogation.
    /// </summary>
    /// <remarks>
    /// Valid range: 0-2147483647. Default: 0. A value of 0 disables this feature.
    /// </remarks>
    int PeriodicCiInterval { get; set; }

    /// <summary>
    /// Gets or sets whether to send a test command periodically.
    /// </summary>
    bool TestProcedure { get; set; }

    /// <summary>
    /// Gets or sets the rate in seconds at which the Test Command will occur.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-86400. Default: 15. Only applicable when TestProcedure is enabled.
    /// </remarks>
    int TestProcedurePeriod { get; set; }

    /// <summary>
    /// Gets or sets whether to play back events for buffered data.
    /// </summary>
    /// <remarks>
    /// When disabled, only the most recent event is reported.
    /// </remarks>
    bool PlaybackEvents { get; set; }

    /// <summary>
    /// Gets or sets the number of events each tag can buffer.
    /// </summary>
    /// <remarks>
    /// Valid range: 1-10000. Default: 100. Only applicable when PlaybackEvents is enabled.
    /// </remarks>
    int PlaybackBufferSize { get; set; }

    /// <summary>
    /// Gets or sets the rate in milliseconds at which events are played back.
    /// </summary>
    /// <remarks>
    /// Valid range: 50-10000. Default: 2000. Only applicable when PlaybackEvents is enabled.
    /// </remarks>
    int PlaybackRate { get; set; }
}
