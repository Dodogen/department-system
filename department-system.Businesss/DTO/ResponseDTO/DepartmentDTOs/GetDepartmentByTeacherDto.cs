using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.DepartmentDTOs;

public class GetDepartmentByTeacherDto
{
	public required Teacher Teacher { get; set; }
	public required Department Department { get; set; }
}
