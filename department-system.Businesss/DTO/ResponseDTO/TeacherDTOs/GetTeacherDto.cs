using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.TeacherDTOs;

public class GetTeacherDto : BaseResponseModelDto
{
	public required string Surname { get; set; }
	public required string Name { get; set; }
	public string? MiddleName { get; set; }
	public required Department Department { get; set; }
	public required string Email { get; set; }
	public List<GradeBook> GradeBookNotes { get; set; } = new List<GradeBook>();
}
