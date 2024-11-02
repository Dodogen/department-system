using department_system.DataAccess.Configuration.Constants;
using department_system.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
	public void Configure(EntityTypeBuilder<Department> builder)
	{
		builder.HasKey(x=>x.Id);

		builder.Property(x => x.Id)
			.ValueGeneratedOnAdd()
			.IsRequired();

		builder.Property(x => x.Name)
			.HasMaxLength(EntityConfigurationRestricts.INITIAL_MAX_LEN)
			.IsRequired();

		builder.Property(x => x.DepartmentHead)
			.IsRequired();

		// 1 -> M
		builder.HasMany(d => d.Teachers)
			.WithOne();

		// 1 -> M
		builder.HasMany(d => d.Disciplines)
			.WithOne();
	}
}
