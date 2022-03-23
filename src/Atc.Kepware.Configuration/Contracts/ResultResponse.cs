namespace Atc.Kepware.Configuration.Contracts;

[Serializable]
public sealed class ResultResponse<TResult>
{
    public ResultResponse()
    {
        // Dummy for serialization//Mapping
    }

    public ResultResponse(
        HttpStatusCode? statusCode,
        TResult? data)
    {
        CommunicationSucceeded = true;
        StatusCode = statusCode;
        Data = data;
    }

    public ResultResponse(
        HttpStatusCode? statusCode,
        TResult? data,
        string message)
    {
        CommunicationSucceeded = true;
        StatusCode = statusCode;
        Data = data;
        Message = message;
    }

    public ResultResponse(
        Exception exception)
    {
        CommunicationSucceeded = false;
        Exception = exception;
    }

    public bool CommunicationSucceeded { get; set; }

    public HttpStatusCode? StatusCode { get; set; }

    public TResult? Data { get; set; }

    public string? Message { get; set; }

    public Exception? Exception { get; set; }
}