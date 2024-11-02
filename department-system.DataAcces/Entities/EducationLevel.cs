using System.Collections.Generic;

namespace department_system.DataAccess.Entities
{
	public class EducationLevel : BaseEntity
	{
		public string Name { get; set; }
		public List<Student> Students { get; set; } = new List<Student>();
	}
}
