using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.StudentDTOs;

public class GetStudentDto : BaseResponseModelDto
{
	public required string Surname { get; set; }
	public required string Name { get; set; }
	public string? MiddleName { get; set; }
	public DateTime ReceiptDate { get; set; }
	public required string Email { get; set; }
	public DateTime Birthday { get; set; }
	public required EducationLevel EducationLevel { get; set; }
	public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
}
