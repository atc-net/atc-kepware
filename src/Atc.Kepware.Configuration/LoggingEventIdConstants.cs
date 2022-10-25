namespace Atc.Kepware.Configuration;

internal static class LoggingEventIdConstants
{
    public const int ConnectionInformationNotSet = 10000;

    public const int GetSucceeded = 10010;
    public const int GetNotFound = 10011;
    public const int GetFailure = 10012;

    public const int PostSucceeded = 10020;
    public const int PostFailure = 10021;

    public const int PutSucceeded = 10030;
    public const int PutFailure = 10031;

    public const int DeleteSucceeded = 10040;
    public const int DeleteFailure = 10041;
}