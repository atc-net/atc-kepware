namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient LoggerMessages.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "OK")]
public partial class KepwareConfigurationClient
{
    private readonly ILogger<KepwareConfigurationClient> logger;

    [LoggerMessage(
        EventId = LoggingEventIdConstants.PostSucceeded,
        Level = LogLevel.Trace,
        Message = "Successfully posted to pathTemplate '{pathTemplate}'.")]
    private partial void LogPostSucceeded(string pathTemplate);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.PostFailure,
        Level = LogLevel.Error,
        Message = "Failed to post to pathTemplate '{pathTemplate}': '{errorMessage}'.")]
    private partial void LogPostFailure(string pathTemplate, string errorMessage);
}
