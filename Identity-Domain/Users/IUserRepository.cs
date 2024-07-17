namespace Identity_Domain.Users;

public interface IUserRepository
{
    // Commands.
    Task CreateAsync(User user, CancellationToken cancellationToken = default);
    void Update(User user);
    void Delete(User user);

    // Queries.
    Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<User> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
    Task<IQueryable<User>> GetByNameAsync(string name, CancellationToken cancellationToken = default);
}
