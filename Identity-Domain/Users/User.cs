namespace Identity_Domain.Users;

public sealed class User
{
    private User(string firstName, string lastName, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    private User() { }

    public string FirstName { get; private set; } = default!;
    public string  LastName { get; private set; } = default!;
    public string  Email { get; private set; } = default!;
    public string Password { get; private set; } = default!;

    public static User Create(string firstName, string lastName, string email, string password)
    {
        User user = new User(firstName, lastName, email, password);

        user.Raise();

        return user;
    }
}
