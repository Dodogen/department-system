using department_system.DataAccess.Configuration.Constants;
using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
	public void Configure(EntityTypeBuilder<Student> builder)
	{
		//builder.ToTable("Students");

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

		builder.Property(s => s.ReceiptDate)
			.IsRequired();

		builder.Property(s => s.Email)
			.IsRequired() 
			.HasMaxLength(EntityConfigurationRestricts.INITIAL_MAX_LEN);

		builder.Property(s => s.EducationLevel)
			.IsRequired();

		builder.HasOne(s => s.EducationLevel)
			.WithMany(x=>x.Students);

		builder.Property(s => s.Birthday)
			.IsRequired();

		builder.HasMany(s => s.GradeBookNotes)
			.WithOne();
	}
}
