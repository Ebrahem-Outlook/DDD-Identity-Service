using Identity_Domain.Core.BaseType;

namespace Identity_Domain.Users.ValueObjects;

public sealed class Password : ValueObject
{
    private Password(string value) => Value = value;

    public string Value { get; }

    public static Password Create(string value) => new Password(value);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
