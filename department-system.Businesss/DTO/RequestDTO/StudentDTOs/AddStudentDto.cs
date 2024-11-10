using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.RequestDTO.StudentDTOs;

public class AddStudentDto
{
	public required string Surname { get; set; }
	public required string Name { get; set; }
	public string? MiddleName { get; set; }
	public required DateTime ReceiptDate { get; set; }
	public required string Email { get; set; }
	public required EducationLevel EducationLevel { get; set; }
	public required DateTime Birthday { get; set; }
	public required string Password { get; set; }
}
