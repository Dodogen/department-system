using System.Collections.Generic;

namespace department_system.DataAccess.Entities
{
	public class Department : BaseEntity
	{
		public string Name { get; set; }
		public Teacher DepartmentHead { get; set; }
		public List<Teacher> Teachers { get; set; } = new List<Teacher>();
		public List<Discipline> Disciplines { get; set; } = new List<Discipline>();
	}
}
