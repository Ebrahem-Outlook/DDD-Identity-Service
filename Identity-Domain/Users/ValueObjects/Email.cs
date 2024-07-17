using Identity_Domain.Core.BaseType;

namespace Identity_Domain.Users.ValueObjects;

public sealed class Email : ValueObject
{
    private Email(string value) => Value = value;

    public string Value { get; }

    public static Email Create(string value) => new Email(value);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
