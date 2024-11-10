using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.RequestDTO.DisciplineDTOs;

public class UpdateDisciplineDepartmentDto
{
	public int DisId { get; set; }
	public required Department NewDepartment{ get; set; }
}
