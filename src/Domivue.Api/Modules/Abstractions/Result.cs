using System.Diagnostics.CodeAnalysis;
using Domivue.Api.Modules.Abstractions;

public class Result{

    // the state of the result
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }

    // create non-generic result
    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error) => new(false, error);

    // create generic result
    public static Result<TValue> Success<TValue> (TValue value) => new(value, true, Error.None);
    public static Result<TValue> Failure<TValue> (Error error) => new(default, false, error);
    public static Result<TValue> Create<TValue> (TValue? value) => value is not null ? Success(value) : Failure<TValue>(Error.NullValue);

    // The constructor is protected internal to prevent instantiation from outside the class
    protected internal Result(bool isSuccess, Error error){
        if(isSuccess && error != Error.None){
            throw new InvalidOperationException();
        }

        if(!isSuccess && error == Error.None){
            throw new InvalidOperationException();
        }

        IsSuccess = isSuccess;
        Error = error;
    }

}

public class Result<TValue> : Result{
    private readonly TValue? _value;

    protected internal Result(TValue? value, bool isSuccess, Error error)
        :base(isSuccess, error)
    {
        _value = value;
    }

    [NotNull]
    public TValue Value => IsSuccess ? _value! : throw new InvalidOperationException("The value of a failure result can not be accessed.");

    public static implicit operator Result<TValue>(TValue? value) => Create(value);
}