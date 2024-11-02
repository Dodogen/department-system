using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
	public void Configure(EntityTypeBuilder<Teacher> builder)
	{
		throw new NotImplementedException();
	}
}
