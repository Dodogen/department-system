using department_system.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace department_system.DataAccess;

public class DatabaseContext : IdentityDbContext<Student, IdentityRole<int>, int>
{
	public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
	public DbSet<Department> Departments { get; set; }
	public DbSet<EducationLevel> EducationLevels { get; set; }
	public DbSet<GradeBook> GradeBookNotes { get; set; }
	public DbSet<Discipline> Disciplines { get; set; }
	public DbSet<Teacher> Teachers { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

		base.OnModelCreating(builder);
	}

}