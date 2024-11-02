using System.Collections.Generic;

namespace department_system.DataAccess.Entities
{
	public class Teacher : BaseEntity
	{
		public string Surname { get; set; }
		public string Name { get; set; }
		public string MiddleName { get; set; }
		public Department Department { get; set; }
		public string Email { get; set; }
		public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
	}
}
