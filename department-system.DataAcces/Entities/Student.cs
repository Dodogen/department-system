using System;
using System.Collections.Generic;

namespace department_system.DataAccess.Entities
{
	public class Student : BaseEntity
	{
		public string Surname { get; set; }
		public string Name { get; set; }
		public string MiddleName { get; set; }
		public DateTime ReceiptDate { get; set; }
		public string Email { get; set; }
		public EducationLevel EducationLevel { get; set; }
		public DateTime Birthday { get; set; }
		public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
	}
}
