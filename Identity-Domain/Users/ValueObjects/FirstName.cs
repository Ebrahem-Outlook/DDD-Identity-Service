using Identity_Domain.Core.BaseType;

namespace Identity_Domain.Users.ValueObjects;

public sealed class FirstName : ValueObject
{
    private FirstName(string value) => Value = value;   

    public string Value { get; }

    public static FirstName Create(string value) => new FirstName(value);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;   
    }
}
