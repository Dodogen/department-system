using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class GradeBookConfiguration : IEntityTypeConfiguration<GradeBook>
{
	public void Configure(EntityTypeBuilder<GradeBook> builder)
	{
		throw new NotImplementedException();
	}
}
