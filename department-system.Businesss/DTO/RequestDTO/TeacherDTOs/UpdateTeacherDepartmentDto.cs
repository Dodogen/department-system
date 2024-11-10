using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.RequestDTO.TeacherDTOs;

public class UpdateTeacherDepartmentDto
{
	public int TeacherId { get; set; }
	public required Department NewDepartment { get; set; }
}
