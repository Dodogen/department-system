using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace department_system.DataAccess.Configuration
{
	public class DepartmentConfiguration : IEntityTypeConfiguration<User>
	{
	}
}
