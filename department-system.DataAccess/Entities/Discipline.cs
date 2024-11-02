using System.Collections.Generic;

namespace department_system.DataAccess.Entities
{
	public class Discipline : BaseEntity
	{
		public string Name { get; set; }
		public Department Department { get; set; }
		public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
	}
}
