namespace Atc.Kepware.Configuration.Contracts;

public sealed class KepwareResultResponse<TResult>
{
    public KepwareResultResponse(
        bool isSuccessful,
        HttpStatusCode? statusCode,
        TResult? result,
        string? errorMessage)
    {
        IsSuccessful = isSuccessful;
        StatusCode = statusCode;
        Result = result;
        ErrorMessage = errorMessage;
    }

    public bool IsSuccessful { get; }

    public HttpStatusCode? StatusCode { get; }

    public TResult? Result { get; }

    public string? ErrorMessage { get; }
}