using department_system.DataAccess.Entities;
using department_system.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace department_system.DataAccess.Repositories.Implementations;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
	protected readonly DatabaseContext Context;
	protected readonly DbSet<TEntity> DbSet;

	protected BaseRepository(DatabaseContext context)
	{
		Context = context;
		DbSet = context.Set<TEntity>();
	}

	public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
	{
		var addedEntity = (await DbSet.AddAsync(entity, cancellationToken)).Entity;
		await Context.SaveChangesAsync(cancellationToken);
		return addedEntity;
	}

	public async Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken)
	{
		var deletedEntity = DbSet.Remove(entity).Entity;
		await Context.SaveChangesAsync(cancellationToken); 
		return deletedEntity;
	}

	public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
	{
		return await DbSet.ToListAsync(cancellationToken);
	}

	public async Task<IEnumerable<TEntity>> GetAllByPredicateAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
	{
		return await DbSet.Where(predicate).ToListAsync(cancellationToken);
	}

	public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
	{
		return await DbSet.Where(x=>x.Id == id).FirstOrDefaultAsync(cancellationToken);
	}

	public async Task<TEntity?> GetFirstByPredicateAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
	{
		return await DbSet.Where(predicate).FirstOrDefaultAsync(cancellationToken);
	}

	public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken)
	{
		DbSet.Update(entity);
		await Context.SaveChangesAsync(cancellationToken);
		return entity;
	}
}
