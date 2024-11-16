using department_system.DataAccess.Entities;

namespace department_system.Business.DTO.RequestDTO.DepartmentDTOs;

public class AddDepartmentDto
{
	public required string DepartmentName {  get; set; }
	public required Teacher DepartmentHead { get; set; }
}
