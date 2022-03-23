namespace Atc.Kepware.Configuration.Contracts;

public sealed class KepwareResultResponse<TResult>
{
    public KepwareResultResponse(
        HttpStatusCode? statusCode,
        TResult? result)
    {
        CommunicationSucceeded = true;
        StatusCode = statusCode;
        Result = result;
    }

    public KepwareResultResponse(
        HttpStatusCode? statusCode,
        TResult? result,
        string message)
    {
        CommunicationSucceeded = true;
        StatusCode = statusCode;
        Result = result;
        Message = message;
    }

    public KepwareResultResponse(
        Exception exception)
    {
        CommunicationSucceeded = false;
        Exception = exception;
    }

    public bool CommunicationSucceeded { get; }

    public HttpStatusCode? StatusCode { get; }

    public TResult? Result { get; }

    public string? Message { get; set; }

    public Exception? Exception { get; }
}