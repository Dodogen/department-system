using department_system.DataAccess.Entities;
using department_system.DataAccess.Repositories.Interfaces;

namespace department_system.DataAccess.Repositories.Implementations;

public class DisciplineRepository : BaseRepository<Discipline>, IDisciplineRepository
{
	public DisciplineRepository(DatabaseContext dbContext) : base(dbContext) { }
}
