using Microsoft.EntityFrameworkCore.Storage;

namespace Identity_Application.Core.Abstractions.Data;

public interface IUnitOfWork
{
    Task<IDbContextTransaction> BeginTransation(CancellationToken cancellationToken);


    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
