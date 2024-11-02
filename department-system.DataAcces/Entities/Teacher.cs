namespace department_system.DataAccess.Entities;

public class Teacher : BaseEntity
{
	public required string Surname { get; set; }
	public required string Name { get; set; }
	public string? MiddleName { get; set; }
	public required Department Department { get; set; }
	public required string Email { get; set; }
	public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
}
