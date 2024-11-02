using department_system.DataAccess.Configuration.Constants;
using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class GradeBookConfiguration : IEntityTypeConfiguration<GradeBook>
{
	public void Configure(EntityTypeBuilder<GradeBook> builder)
	{
		builder.HasKey(x => x.Id);

		builder.Property(x => x.Id)
			.ValueGeneratedOnAdd()
			.IsRequired();

		builder.Property(x => x.Student)
			.IsRequired();

		builder.HasOne(x => x.Student)
			.WithMany(x => x.GradeBookNotes);

		builder.Property(x => x.Teacher)
			.IsRequired();

		builder.HasOne(x => x.Teacher)
			.WithMany(x => x.GradeBookNotes);

		builder.Property(x => x.Discipline)
			.IsRequired();

		builder.HasOne(x => x.Discipline)
			.WithMany(x => x.GradeBookNotes);


		builder.Property(x => x.Grade)
			.IsRequired();

		builder.Property(x => x.AssessmentDay)
			.IsRequired();

	}
}
