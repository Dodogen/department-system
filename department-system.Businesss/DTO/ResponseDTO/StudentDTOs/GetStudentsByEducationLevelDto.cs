using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.StudentDTOs;

public class GetStudentsByEducationLevelDto
{
	public required EducationLevel EducationLevel { get; set; }
	public List<Student> Students { get; set; } = new List<Student>();
}
