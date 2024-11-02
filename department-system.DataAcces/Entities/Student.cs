using System;
using System.Collections.Generic;

namespace department_system.DataAccess.Entities
{
	public class Student : BaseEntity
	{
		public required string Surname { get; set; }
		public required string Name { get; set; }
		public string? MiddleName { get; set; }
		public required DateTime ReceiptDate { get; set; }
		public required string Email { get; set; }
		public required EducationLevel EducationLevel { get; set; }
		public required DateTime Birthday { get; set; }
		public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
	}
}
