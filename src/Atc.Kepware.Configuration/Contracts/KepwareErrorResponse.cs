namespace Atc.Kepware.Configuration.Contracts;

public class KepwareErrorResponse
{
    public HttpStatusCode Code { get; set; }

    public string? Message { get; set; }

    public string GetCodeAndMessage()
        => string.IsNullOrEmpty(Message)
            ? Code.ToNormalizedString()
            : $"{Code.ToNormalizedString()} - {Message}";

    /// <inheritdoc />
    public override string ToString()
        => $"{nameof(Code)}: {Code}, {nameof(Message)}: {Message}";
}