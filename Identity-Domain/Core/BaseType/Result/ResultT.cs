namespace Identity_Domain.Core.BaseType.Result;

public class Result<TValue> : Result where TValue : class
{
    protected internal Result(TValue value, bool isSuccess, Error error) 
        : base(isSuccess, error)
    {

    }


}
