using department_system.DataAccess.Entities;
using department_system.DataAccess.Repositories.Interfaces;

namespace department_system.DataAccess.Repositories.Implementations;

public class GradeBookRepository : BaseRepository<GradeBook>, IGradeBookRepository
{
	public GradeBookRepository(DatabaseContext dbContext) : base(dbContext) { }
}
