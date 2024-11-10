using department_system.DataAccess.Entities;
using department_system.DataAccess.Repositories.Interfaces;

namespace department_system.DataAccess.Repositories.Implementations;

public class EducationLevelRepository : BaseRepository<EducationLevel>, IEducationLevelRepository
{
	public EducationLevelRepository(DatabaseContext dbContext) : base(dbContext) { }
}
