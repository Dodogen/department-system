using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.ResponseDTO.DepartmentDTOs;

public class GetDepartmentByDisciplineDto
{
	public required Discipline Discipline { get; set; }
	public required Department Department { get; set; }
}
