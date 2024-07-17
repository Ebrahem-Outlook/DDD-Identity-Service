using Identity_Domain.Core.BaseType;
using Microsoft.EntityFrameworkCore;

namespace Identity_Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
