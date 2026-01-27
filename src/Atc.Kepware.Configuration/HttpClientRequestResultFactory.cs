namespace Atc.Kepware.Configuration;

public static class HttpClientRequestResultFactory<TResult>
{
    [SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "OK.")]
    [SuppressMessage("Design", "MA0018:Do not declare static members on generic types", Justification = "OK.")]
    public static HttpClientRequestResult<TResult?> CreateBadRequest(
        string validationErrorMessage)
        => new(
            HttpStatusCode.BadRequest,
            data: default,
            message: validationErrorMessage);
}