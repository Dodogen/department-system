using department_system.DataAccess.Entities;
using System.Linq.Expressions;

namespace department_system.DataAccess.Repositories.Interfaces;

internal interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
	Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
	Task<TEntity?> GetFirstByPredicateAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
	Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
	Task<IEnumerable<TEntity>> GetAllByPredicateAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
	Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);
	Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken);
	Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken);
}
