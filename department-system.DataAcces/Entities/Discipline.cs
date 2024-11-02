namespace department_system.DataAccess.Entities
{
	public class Discipline : BaseEntity
	{
		public required string Name { get; set; }
		public required Department Department { get; set; }
		public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
	}
}
