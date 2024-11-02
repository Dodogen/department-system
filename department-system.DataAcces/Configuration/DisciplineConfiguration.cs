using department_system.DataAccess.Configuration.Constants;
using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
{
	public void Configure(EntityTypeBuilder<Discipline> builder)
	{
		builder.HasKey(x => x.Id);

		builder.Property(x => x.Id)
			.ValueGeneratedOnAdd()
			.IsRequired();

		builder.Property(x => x.Name)
			.HasMaxLength(EntityConfigurationRestricts.INITIAL_MAX_LEN)
			.IsRequired();

		builder.Property(x => x.Department)
			.IsRequired();

		builder.HasMany(d => d.GradeBookNotes)
			.WithOne();
	}
}
