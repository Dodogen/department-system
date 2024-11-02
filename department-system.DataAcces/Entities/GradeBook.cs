using System;

namespace department_system.DataAccess.Entities
{
	public class GradeBook : BaseEntity
	{
		public Student Student { get; set; }
		public Teacher Teacher { get; set; }
		public Discipline Discipline { get; set; }
		public short Grade {  get; set; }
		public DateTime AssessmentDay { get; set; }
	}
}
