using Microsoft.AspNetCore.Identity;

namespace department_system.DataAccess.Entities;

public class Student : IdentityUser<int>
{
	public required string Surname { get; set; }
	public required string Name { get; set; }
	public string? MiddleName { get; set; }
	public required DateTime ReceiptDate { get; set; }
	public override required string Email { get; set; }
	public required EducationLevel EducationLevel { get; set; }
	public required DateTime Birthday { get; set; }
	public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
}
