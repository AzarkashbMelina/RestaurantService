using System.Net;

namespace RestaurantService.Application.Common.Results;

public record Error(string Code, string Message)
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.NullValue", "a null value has encountered");
    public static readonly Error UserNotFound = new("Error.UserNotFound", "User Not Found");

}

public class Result
{
    protected Result(bool isSuccess, Error? error, HttpStatusCode status = HttpStatusCode.OK, string? message = null)
    {
        if (isSuccess && error != null && error != Error.None)
        {
            throw new InvalidOperationException("success must not contains any error");
        }

        if (!isSuccess && (error is null || error == Error.None))
        {
            throw new InvalidOperationException("failure must contains an error");
        }

        IsSuccess = isSuccess;
        Error = error;
        Status = status;
        Message = message;
    }

    public string? Message { get; set; }
    public bool IsSuccess { get; set; }
    public Error? Error { get; set; }
    public HttpStatusCode Status { get; set; }

    public static Result Success(HttpStatusCode status = HttpStatusCode.OK, string? message = null) =>
        new(true, Error.None, status, message);

    public static Result Failure(Error error, HttpStatusCode status = HttpStatusCode.InternalServerError, string? message = null) =>
        new(false, error, status, message);

    public static Result<T> Success<T>(T data, HttpStatusCode status = HttpStatusCode.OK, string? message = null) =>
        new(data, true, null, status, message);

    public static Result<T> Failure<T>(Error error, HttpStatusCode status = HttpStatusCode.InternalServerError, string? message = null) =>
        new(default, false, error, status, message);

    public static Result<T> Create<T>(T? value) =>
        value is not null
            ? Success(value)
            : Failure<T>(Error.NullValue);

    public override string ToString() =>
        IsSuccess ? "Success" : $"Failure: {Error?.Code} - {Error?.Message}";
}

public class Result<T> : Result
{

    public T? Data { get; set; }
    public List<string> Errors { get; set; }

    internal Result(T? data, bool isSuccess, Error? error, HttpStatusCode status = HttpStatusCode.OK, string? message = null)
        : base(isSuccess, error, status, message)
    {
        Data = data;
    }

    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<Error, TResult> onFailure) =>
        IsSuccess ? onSuccess(Data!) : onFailure(Error!);
}
