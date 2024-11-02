using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
{
	public void Configure(EntityTypeBuilder<Discipline> builder)
	{
		throw new NotImplementedException();
	}
}
