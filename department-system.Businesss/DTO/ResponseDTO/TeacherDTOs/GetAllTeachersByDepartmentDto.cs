using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.TeacherDTOs;

public class GetAllTeachersByDepartmentDto
{
	public required Department Department { get; set; }
	public List<Teacher> Teachers { get; set; } = new List<Teacher>();
}
