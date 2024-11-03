using department_system.DataAccess.Entities;
using department_system.DataAccess.Repositories.Interfaces;

namespace department_system.DataAccess.Repositories.Implementations;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
	public DepartmentRepository(DatabaseContext dbContext) : base(dbContext) { }
}
