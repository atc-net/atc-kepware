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
        EventId = LoggingEventIdConstants.GetSucceeded,
        Level = LogLevel.Trace,
        Message = "Successfully retrieved data from pathTemplate '{pathTemplate}'.")]
    private partial void LogGetSucceeded(string pathTemplate);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.GetFailure,
        Level = LogLevel.Error,
        Message = "Failed to retrieve data from pathTemplate '{pathTemplate}': '{errorMessage}'.")]
    private partial void LogGetFailure(string pathTemplate, string errorMessage);

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
