using department_system.DataAccess.Configuration.Constants;
using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class EducationLevelConfiguration : IEntityTypeConfiguration<EducationLevel>
{
	public void Configure(EntityTypeBuilder<EducationLevel> builder)
	{
		builder.HasKey(x => x.Id);

		builder.Property(x => x.Id)
			.ValueGeneratedOnAdd()
			.IsRequired();

		builder.Property(x => x.Name)
			.HasMaxLength(EntityConfigurationRestricts.NAMING_MAX_LEN);

		builder.HasMany(d => d.Students)
			.WithOne();
	}
}
