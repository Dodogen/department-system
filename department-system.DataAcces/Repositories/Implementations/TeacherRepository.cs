using department_system.DataAccess.Entities;
using department_system.DataAccess.Repositories.Interfaces;

namespace department_system.DataAccess.Repositories.Implementations;

public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
{
	public TeacherRepository(DatabaseContext dbContext) : base(dbContext) { }
}
