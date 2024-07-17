using Identity_Domain.Core.BaseType;

namespace Identity_Domain.Users.ValueObjects;

public sealed class LastName : ValueObject
{
    private LastName(string value) => Value = value;

    public string Value { get; }

    public static LastName Create(string value) => new LastName(value);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
