using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class EducationLevelConfiguration : IEntityTypeConfiguration<EducationLevel>
{
	public void Configure(EntityTypeBuilder<EducationLevel> builder)
	{
		throw new NotImplementedException();
	}
}
