using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using department_system.DataAccess.Configuration.Constants;


namespace department_system.DataAccess.Configuration;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
	public void Configure(EntityTypeBuilder<Teacher> builder)
	{
		builder.HasKey(x => x.Id);

		builder.Property(x => x.Id)
			.ValueGeneratedOnAdd()
			.IsRequired();

		builder.Property(s => s.Surname)
			.IsRequired()
			.HasMaxLength(EntityConfigurationRestricts.INITIAL_MAX_LEN);

		builder.Property(s => s.Name)
			.IsRequired()
			.HasMaxLength(EntityConfigurationRestricts.INITIAL_MAX_LEN);

		builder.Property(s => s.MiddleName)
			.HasMaxLength(EntityConfigurationRestricts.INITIAL_MAX_LEN);

		builder.Property(x => x.Department)
			.IsRequired();

		builder.HasOne(x => x.Department)
			.WithMany(x => x.Teachers);

		builder.Property(s => s.Email)
			.IsRequired()
			.HasMaxLength(EntityConfigurationRestricts.INITIAL_MAX_LEN);

		builder.HasMany(s => s.GradeBookNotes)
			.WithOne();
	}
}
